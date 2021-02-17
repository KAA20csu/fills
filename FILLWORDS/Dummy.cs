using System;
using System.Collections.Generic;
using System.Text;

namespace FILLWORDS
{
    class Dummy
    {
        public void Continue()
        {
            Console.Clear();
            Console.WriteLine("Здесь скоро будет Continue...");
        }
        public void Rating()
        {
            Console.Clear();
            Console.WriteLine("Здесь скоро будет Rating...");
        }
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Bye-bye!");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
