using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> movies = new MyDictionary<string,int>();

            movies.Add("Circle", 1);
            movies.Add("Tau", 2);
            movies.Add("Lucy", 3);
            movies.Add("Matrix", 4);
            movies.Add("Geostorm", 5);

            movies.List();











        }
    }
}
