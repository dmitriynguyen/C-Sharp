using System;

class Program
{
    static void Main()
    {
        var st = new Stack<int>();
        st.Push(4);
        st.Push(3);
        st.Push(2);
        st.Push(1);

        Console.WriteLine(st);

        Console.WriteLine(st.Reverse());
        Console.WriteLine(st);

        Console.ReadLine();
    }
}
