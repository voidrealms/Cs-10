using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customers = new List<string>();
            customers.Add("Bob"); //0
            customers.Add("Mary"); //1
            //Here
            customers.Add("Chad"); //2

            customers.Insert(2, "Heather");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            List<int> ages = new List<int>();
            ages.Add(10);
            ages.Add(10);
            ages.Add(10);
            ages.Add(10);
            ages.Add(10);
            ages.Add(10);
            ages.Add(10);

            Console.Read();
        }
    }
}
