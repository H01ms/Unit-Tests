using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class New_Main_Class
    {
        private Product S = new Product();
        private Dieta R = new Dieta();
        public void Init(int k1, int k2, double c1, double c2, int Kol, int k, double c, int kol)
        {
            R.Init(k1, k2, c1, c2, Kol);
            S.Init(k, c, kol);
        }
        public void Display()
        {
            Console.Write("Класс Dieta: \n");
            R.Display();
            Console.Write("\nКласс Product: \n");
            S.Display();
        }
    }
}
