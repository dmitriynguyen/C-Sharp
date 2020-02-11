using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task_6_2
{
    class Catalog
    {
        public Dictionary<string, Books> _catalog = new Dictionary<string, Books>();

        public Books this[string i]
        {
            get
            {
                try
                {
                    if (Regex.IsMatch(i, @"\d{13}"))
                    {
                        i = i.Insert(3, "-");
                        i = i.Insert(5, "-");
                        i = i.Insert(8, "-");
                        i = i.Insert(15, "-");
                    }
                    if (Regex.IsMatch(i, @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}"))
                    {
                        foreach (var x in _catalog)
                        {
                            if (x.Key == i)
                                return x.Value;
                        }
                    }
                    throw new Exception();
                }
                catch (Exception)
                {
                    return new Books("We haven't got this book", "");
                }
            }
            set
            {
                try
                {
                    if (Regex.IsMatch(i, @"\d{13}"))
                    {
                        i = i.Insert(3, "-");
                        i = i.Insert(5, "-");
                        i = i.Insert(8, "-");
                        i = i.Insert(15, "-");
                    }
                    if (Regex.IsMatch(i, @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}"))
                    {
                        if (value is Books e)
                            _catalog.Add(i, e);
                        else
                            throw new ArgumentException();
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Not right format");
                }
            }
        }
    }
}