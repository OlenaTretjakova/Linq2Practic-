using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Linq2Practicу
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "basket", "program", "potato", "cosmos", "giraffe", "lightning", "watermelon" };

            Console.WriteLine("Strings array:");
            foreach (var item in strings)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            SortStrByLengthIncreas(strings);

            Console.WriteLine();
            Console.WriteLine();

            SortStrByLengерReduction(strings);

            Console.WriteLine();
            Console.WriteLine();

            int[] array1 = { 1, 2, 3, 3, 3, 4, 4, 4, 5, 6, 7, 8 };

            Console.WriteLine("Array 1:");
            ShowArray(array1);
            Console.WriteLine();

            int[] array2 = { 4, 5, 6, 7, 8, 9, 0, 11 };
            Console.WriteLine("Array 2:");
            ShowArray(array2);
            Console.WriteLine();
            Console.WriteLine();

            var array3 = array1.Except(array2);
            Console.WriteLine("Except array:");
            ShowArray(array3);
            Console.WriteLine();
            Console.WriteLine();

            var array4 = array1.Union(array2);
            Console.WriteLine("Union arrays:");
            ShowArray(array4);
            Console.WriteLine();
            Console.WriteLine();

            var array5 = array1.Distinct();
            Console.WriteLine("Distinkt array 1:");
            ShowArray(array5);
            Console.WriteLine();
            Console.WriteLine();

            Auto[] arrAuto1 = new Auto[] { new Auto("BMW", DateTime.Parse("12/12/2022"),"Germany"),
                                           new Auto("BMW", DateTime.Parse("10/01/2024"),"Germany"),
                                           new Auto("Volvo", DateTime.Parse("08/08/2020"),"Sweden"),
                                           new Auto("Volvo", DateTime.Parse("08/04/2020"),"Sweden")};

            Auto[] arrAuto2 = new Auto[] { new Auto("BMW", DateTime.Parse("01/01/2012"),"Germany"),
                                           new Auto("Mercedes", DateTime.Parse("10/01/2024"),"Germany"),
                                           new Auto("Mercedes", DateTime.Parse("08/08/2020"),"Germany"),
                                           new Auto("Volvo", DateTime.Parse("08/06/2010"),"Sweden")};

            Console.WriteLine("Array 1:");
            ShowArray(arrAuto1);

            Console.WriteLine();

            Console.WriteLine("Array 2:");
            ShowArray(arrAuto2);



            Console.WriteLine();
            Console.WriteLine("Union array1 and array2 by produser:");

            var producersArr1 = arrAuto1.Select(auto => auto.Producer);
            var producersArr2 = arrAuto2.Select(auto => auto.Producer);
            var producersUnion = producersArr1.Union(producersArr2);


            Console.WriteLine();

            ShowArray(producersUnion);










            Console.ReadLine();
        }

        static void SortStrByLengthIncreas(string[] str)
        {
            var sortStrByLength = str.OrderBy(item => item.Length);

            Console.WriteLine("Sort strings array by increas:");
            foreach (var item in str)
            {
                Console.Write(item + " ");
            }
        }

        static void SortStrByLengерReduction(string[] str)
        {
            var sortStrByLength = str.OrderByDescending(item => item.Length);

            Console.WriteLine("Sort strings array by reduction:");
            foreach (var item in str)
            {

                Console.Write(item + " ");
            }
        }

        static void ShowArray<T>(IEnumerable<T> arr)
        {
            foreach (var item in arr)
            {
                if (!typeof(T).IsPrimitive)
                {
                    Console.WriteLine(item + "\n");
                }
                else
                {
                    Console.Write(item + " ");

                }
            }
        }
    }
    
}
