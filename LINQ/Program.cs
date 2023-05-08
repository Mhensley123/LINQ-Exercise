
using System;
using System.Collections.Generic;
using System.Linq;
    

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>() { "a", "b", "c", "d", "e" };
            var myArray = new List<string>() { "Olive Oil in the Streets", "Sesame Seed Panic", "Paprika Pickup Games", "Vinegar Riots", "Salty Shooter" };
            var sentences = myArray.OrderBy(word => word.Length);
            foreach(var item in sentences)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
