using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week14_3
{
    class Program
    {
        public static void Age(int a)
        {
            if (a >= 20)
                Console.Write("年齡:" + a + " 需購買普通票");
            else
                Console.Write("年齡:" + a + " 購買優待票");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week14_3");
            int age;
            Console.Write("請輸入年齡:");
            age = int.Parse(Console.ReadLine());
            Age(age);
            Console.ReadLine();
        }
    }
}
