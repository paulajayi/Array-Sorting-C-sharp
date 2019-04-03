using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = new string[]
            {
                "cherry","orange","apple"
            };
            // Array.Sort(fruits);
            var res = from fruitNames in fruits
                      orderby fruitNames descending
                      select fruitNames;

            foreach(string fruit in res)
            {
                Console.WriteLine(fruit);
                
            }
            Console.ReadLine();
        }
    }
}
