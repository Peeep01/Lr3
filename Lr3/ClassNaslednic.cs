using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    internal class ClassNaslednic : Music
    {
        
       public override string optins()
       {
            Program program = new Program();
            Program.info();
           
            if (Console.ReadKey().Key == ConsoleKey.U)
            {
                Console.WriteLine("\nВерно");
            }
            return null;
            Console.ReadLine();
       }

    }
}
