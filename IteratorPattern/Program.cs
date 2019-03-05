using IteratorPattern.Collections;
using IteratorPattern.Iterators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new SecretCollection();
            collection.AddItem("Ala ma kota", false);
            collection.AddItem("Ola ma pytona ale to tajemnica!", true);
            collection.AddItem("Piotrek ma psa", false);
            collection.AddItem("Piotrek ma też kota", false);
            collection.AddItem("Aga ma kanarka ale to też tajemnica", true);
            collection.AddItem("Jacek ma psa", false);

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Reverse iteration:");
            Console.WriteLine();

            collection.ReverseOrder();

            foreach (var element in collection)
            {
                Console.WriteLine(element.ToString());
            }

            Console.Read();
        }
    }
}