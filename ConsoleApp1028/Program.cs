using System;

namespace second
{
    public delegate string print(string a, int b);
    public class pring
    {
        public static string agg(string a, int b)
        {
            return a + b.ToString();
        }
        public string agg1(string a, int b)
        {
            return a + b.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            print p = pring.agg;
            pring pp = new pring();
            p+= pp.agg1;

            Console.WriteLine(p("string ", 1));
        }
    }
}
