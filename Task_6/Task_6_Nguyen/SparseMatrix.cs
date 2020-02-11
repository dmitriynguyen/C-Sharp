using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_6_Nguyen
{
    class SparseMatrix : IEnumerable<int>
    {
        private SortedDictionary<(int, int), int> _array = new SortedDictionary<(int, int), int>();
        public int _i;
        public int _j;

        public int this[int i, int j]
        {
            get
            {
                if (IsCorrect(i, j))
                {
                    foreach (var x in _array)
                    {
                        if (x.Key == (i, j))
                            return x.Value;
                    }
                    return 0;
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (IsCorrect(i, j))
                {
                    if (value != 0)
                        _array.Add((i, j), value);
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public SparseMatrix(int i, int j)
        {
            if (i != 0)
                _i = i;
            else
                _i = 1;

            if (j != 0)
                _j = j;
            else
                _j = 1;
        }

        public override string ToString()
        {
            string str = "";
            int count = 0;

            for (int i = 0; i < _i * _j; i++)
            {
                str += 0;
                if (count == _j - 1)
                {
                    str += Environment.NewLine;
                    count = -1;
                }
                count++;
            }

            foreach (var x in _array)
            {
                str = str.Remove(_j * x.Key.Item1 + 2 * x.Key.Item1 + x.Key.Item2, 1);
                str = str.Insert(_j * x.Key.Item1 + 2 * x.Key.Item1 + x.Key.Item2, x.Value.ToString());
            }
            return str;
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _i; i++)
                for (int j = 0; j < _j; j++)
                    yield return this[i, j];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<(int, int, int)> GetNonzeroElements()
        {
            foreach (var item in _array)
            {
                yield return (item.Key.Item1, item.Key.Item2, item.Value);
            }
        }

        public int GetCount(int x)
        {
            int count = 0;

            if (x == 0)
            {
                return _i * _j - _array.Count;
            }
            else
            {
                foreach (var k in _array)
                    if (k.Value == x)
                        count++;
                return count;
            }
        }

        private bool IsCorrect(int i, int j) => i >= 0 && i < _i && j >= 0 && j < _j;
    }
}
