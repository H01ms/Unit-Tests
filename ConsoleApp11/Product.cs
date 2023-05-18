using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Product
    {
        private int kalorii;
        private double cost;
        int kolhleb;
        public void Init(int k, double c, int Kol)
        {
            kalorii = k;
            cost = c;
            kolhleb = Kol;
            if (kalorii<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(kalorii));
            }
            if (cost <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(cost));
            }
            if (kolhleb <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(kolhleb));
            }
        }
        public void Read()
        {
            string s = "";
            s = Console.ReadLine();
            string[] s1 = s.Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);
            kalorii = Convert.ToInt32(s1[0]);
            cost = Convert.ToDouble(s1[1]);
        }
        public double Cost()
        {
            return Math.Round(cost / (kalorii + 2 * kolhleb), 2, MidpointRounding.AwayFromZero);
        }
        public void Display()
        {
            Console.WriteLine("Калории:" + kalorii.ToString()); ;
            Console.WriteLine("Стоимость:" + cost.ToString());
            Console.WriteLine("Хлебных единиц: " + kolhleb.ToString());
        }
    }
}
