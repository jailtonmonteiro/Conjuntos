using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 0, 1, 3, 5, 7, 9, 10 };

            //Union
            SortedSet<int> u = new SortedSet<int>(a);
            u.UnionWith(b);
            Console.Write("Union: ");
            PrintCollection(u);

            //Intersection
            SortedSet<int> i = new SortedSet<int>(a);
            i.IntersectWith(b);
            Console.Write("Intersection: ");
            PrintCollection(i);

            //Difference
            SortedSet<int> d = new SortedSet<int>(a);
            d.ExceptWith(b);
            Console.Write("Difference: ");
            PrintCollection(d);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine("");
        }
    }
}