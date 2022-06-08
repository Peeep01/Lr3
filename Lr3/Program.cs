using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ClassNaslednic classNaslednic = new ClassNaslednic();
            classNaslednic.optins();
        }

        public static void info()
        {
            Console.WriteLine("*музыка играет*");
            Console.WriteLine("Чтобы узнать название песни введите: U");
            Console.WriteLine("Нажмите пробел чтобы поставить на паузу");
            Console.Write("Введите символ:");
        }
    }
}
