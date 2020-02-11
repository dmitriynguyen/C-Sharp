using System;

class Program
{
    static void Main()
    {
        var k = new Key(Note.C, Accidental.NoAlteration, Octave.Contra);
        var l = new Key(Note.A, Accidental.Flat, Octave.Subcontra);

        Console.WriteLine(k.Equals(l));
        Console.WriteLine(k.CompareTo(l));
        Console.ReadLine();
    }
}