using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dieta a = new Dieta();
            New_Main_Class c = new New_Main_Class();
            a.Name();
            a.Init(300, 400, (double)125.5, (double)111.7, 100);
            double Sum = a.Cost();
            a.Display();
            Console.Write("\nСумма = " + Sum + "\n");
            Console.Write("\nNew main class:\n");
            c.Init(320, 450, (double)126.5, (double)112.7, 100, 98, (double)101.6, 123);
            c.Display();

        }
    }
}