namespace Task_6_2
{
    class Books
    {
        public string _bookName;
        public string[] _authors;

        public Books(string b, params string[] a)
        {
            if (b == null || b == "")
                _bookName = "Noname";
            else
                _bookName = b;
            if (a == null)
                _authors[0] = "";
            else
                _authors = a;
        }

        public override string ToString()
        {
            return _bookName;
        }
    }
}
