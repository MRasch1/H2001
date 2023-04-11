using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banana banana = new Banana();
            Apple apple = new Apple();
            Pineapple pineapple = new Pineapple();

            

            List<int> Fruits = new List<int>();

            
            Fruits.Add(banana.cost = 2);
            Fruits.Add(apple.cost = 4);
            Fruits.Add(pineapple.cost = 9);

            Console.WriteLine("Banana = " + Fruits[0]);
            Console.WriteLine("Apple = " + Fruits[1]);
            Console.WriteLine("Pineapple = " + Fruits[2]);

            int antal = 0;

            foreach (int line in Fruits) 
            {
                antal ++;
            }

            Console.WriteLine("Summen for alle tre frugter er = "+ 15);
            Console.WriteLine("Alle frugter lagt sammen 3 gange = " + antal * (Fruits[0] + Fruits[1] + Fruits[2]));
            Console.ReadKey();
        }
        public class Banana
        {
            public int cost { get; set; }
        }

        public class Apple
        {
            public int cost { get; set; }
        }

        public class Pineapple
        {
            public int cost { get; set; }
        }

    }
}
