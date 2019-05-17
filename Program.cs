using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            bool bln = true;
 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press q to quit...");
            while (true)
            {
                while(!Console.KeyAvailable)
                {
                    if(!bln)
                        Console.WriteLine("{0:s}", "x");
                    bln = true;
                }
                bln = false;

                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Q)
                    break;
 
                Console.Write("{0} --- ", k.Key);
            }

        }
    }
}
