using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Dieta
    {
        private Product e1 = new Product();
        private Product e2 = new Product();
        private string name = "";
        public void Init(int k1, int k2, double c1, double c2, int Kol)
        {
            e1.Init(k1, c1, Kol);
            e2.Init(k2, c2, Kol);
        }
        public void Read()
        {
            e1.Read();
            e2.Read();
        }
        public void Name()
        {
            name = Console.ReadLine();
        }
        public double Cost()
        {
            double cosT = e1.Cost() + e2.Cost();
            return cosT;
        }
        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine("Продукт-1:");
            e1.Display();
            Console.WriteLine("Продукт-2:");
            e2.Display();
        }
    }
}
