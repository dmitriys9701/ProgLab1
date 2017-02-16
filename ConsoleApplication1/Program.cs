using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class MyCollection
    {
        public static ArrayList NewCollection(int i)
        {
            Random ran = new Random();
            ArrayList arr = new ArrayList();
            for(int j = 0; j < i; j++)
            {
                arr.Add(ran.Next(1, 100));
            }
            return arr;
        }

        public static void RemoveElementMyCollection(int i, int j, ref ArrayList arr)
        {
            arr.RemoveRange(i, j);
        }

        public static void AddElementMyCollection(int i, ref ArrayList arr)
        {
            Random ran = new Random();
            for(int j = 0; j < i; j++)
            {
                arr.Add(ran.Next(1, 50));
            }
        }

        public static void PrintMyCollection(ArrayList arr)
        {
            foreach (int a in arr)
                Console.Write("{0} ", a);
            Console.Write("\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList col = MyCollection.NewCollection(3);
            MyCollection.PrintMyCollection(col);
            MyCollection.AddElementMyCollection(3, ref col);
            MyCollection.PrintMyCollection(col);
            MyCollection.RemoveElementMyCollection(5, 1, ref col);
            MyCollection.PrintMyCollection(col);
            Console.ReadKey();
        }
    }
}
