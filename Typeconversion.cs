using System;

namespace Chapter3
{
    class Typeconversion
    {
        static void Main(string[] args)
        {
            int i = 10, ch = 122;
            short s;
            decimal dec = 1.22222m;
            long l;
            char charval;
            s = (short)i;
            l = (long)dec;
            charval = (char)ch;
            Console.WriteLine("short {0} , long {1} , char {2} ", s, l, charval);
        }
    }
}
