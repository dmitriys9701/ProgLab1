using System;
using System.Collections;

namespace ConsoleApplication1
{
    class MyCollection
    {
        static Random _ran = new Random();

        public static Random Ran
        {
            get
            {
                return _ran;
            }

            set
            {
                _ran = value;
            }
        }

        public static double Random()
        {
            return Ran.NextDouble();
        }

        public static ArrayList NewCollection(int i)
        {
            
            ArrayList arr = new ArrayList();
            for(int j = 0; j < i; j++)
            {
                arr.Add(Random());
            }
            return arr;
        }

        public static void RemoveElementMyCollection(int i, int j, ref ArrayList arr)
        {
            arr.RemoveRange(i, j);
        }

        public static void AddElementMyCollection(int i, ref ArrayList arr)
        {
            for(int j = 0; j < i; j++)
            {
                arr.Add(Random());
            }
        }

        public static void PrintMyCollection(ArrayList arr)
        {
            foreach (double a in arr)
                Console.Write($"{a:0.00} ");
            Console.Write("\n");
        }
    }


    class Program
    {
        static void Main()
        {
            ArrayList col = MyCollection.NewCollection(5);
            MyCollection.PrintMyCollection(col);
            MyCollection.AddElementMyCollection(10, ref col);
            MyCollection.PrintMyCollection(col);
            MyCollection.RemoveElementMyCollection(5, 1, ref col);
            MyCollection.PrintMyCollection(col);
            Console.ReadKey();
        }
    }
}
