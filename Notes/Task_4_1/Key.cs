using System;

public struct Key : IComparable
{
    public byte _note { get; set; }

    public Key(Note x, Accidental y, Octave z)
    {
        _note = (byte)(21 * (int)z + (int)x + (int)y);
        try
        {            
            if (((int)z == 0 && ((int)x + (int)y) < 17) || ((int)z == 8 && ((int)x + (int)y) > 2))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"Возникло исключение - ноты {this} не существует");
        }
    }

    public override string ToString()
    {
        var octave = _note / 21;
        var ost = _note % 21;
        if( ost == 0)
        {
            octave -= 1;
            ost = 21;
        }
        var note = ((ost - 1) / 3) * 3 + 2;
        var accidental = ost - note;
        return $"{(Note)note} {(Accidental)accidental} {(Octave)octave}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Key temp)
        {
            return ConvertToSound() == temp.ConvertToSound();
        }
        else
        {
            throw new ArgumentException();
        }
    }

    private int ConvertToSound()
    {
        var ost = _note / 21 + 1;
        var n = _note % 21;
        if (n == 0)
        {
            n = 21;
            ost -= 1;
        }
        var hCode = (n - ((n * ((n - 1) / 3 + n / 10 - n / 20)) / (1 + ((n - 1) / 3) * 3))) + ost * 12;
        return hCode;
    }

    public override int GetHashCode()
    {
        return ConvertToSound();
    }

    public int CompareTo(object k)
    {
        if (k is Key temp)
        {
            return ConvertToSound() - temp.ConvertToSound();
        }
        else
        {
            throw new ArgumentException();
        }
    }
}