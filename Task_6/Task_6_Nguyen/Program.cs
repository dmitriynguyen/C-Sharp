using System;

namespace Task_6_Nguyen
{
    class Program
    {
        static void Main()
        {
            var m =new SparseMatrix(4, 6);

            m[0, 0] = 0;
            m[0, 1] = 0;

            m[1, 1] = 3;
            m[1, 2] = 4;
            m[1, 3] = 0;
            m[1, 4] = 5;

            m[0, 2] = 1;
            m[0, 3] = 0;
            m[0, 4] = 2;
            m[0, 5] = 0;

            m[1, 0] = 0;
            m[1, 5] = 0;

            Console.WriteLine(m);
            Console.WriteLine(m.GetCount(0));
            foreach (var k in m.GetNonzeroElements())
                Console.WriteLine(k);
            Console.ReadLine();

        }
    }
}
