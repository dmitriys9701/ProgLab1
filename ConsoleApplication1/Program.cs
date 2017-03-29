using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class MyArrayList
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

    class MyStack
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

        public static Stack NewCollection(int i)
        {

            Stack stck = new Stack();
            for (int j = 0; j < i; j++)
            {
                stck.Push(Random());
            }
            return stck;
        }

        //public static void RemoveElementMyCollection(int i, int j, ref Stack stck)
        //{
        //    stck.Pop(i, j);
        //}

        public static void AddElementMyCollection(int i, ref Stack stck)
        {
            for (int j = 0; j < i; j++)
            {
                stck.Push(Random());
            }
        }

        public static void PrintMyCollection(Stack stck)
        {
            foreach (double a in stck)
                Console.Write($"{a:0.00} ");
            Console.Write("\n");
        }
    }

    class MyQueue
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

        public static Queue NewCollection(int i)
        {

            Queue qu = new Queue();
            for (int j = 0; j < i; j++)
            {
                qu.Enqueue(Random());
            }
            return qu;
        }

        //public static void RemoveElementMyCollection(int i, int j, ref Stack stck)
        //{
        //    stck.Pop(i, j);
        //}

        public static void AddElementMyCollection(int i, ref Queue qu)
        {
            for (int j = 0; j < i; j++)
            {
                qu.Enqueue(Random());
            }
        }

        public static void PrintMyCollection(Queue qu)
        {
            foreach (double a in qu)
                Console.Write($"{a:0.00} ");
            Console.Write("\n");
        }
    }

    class MyHashTable
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

        public static Hashtable NewCollection(int i)
        {

            Hashtable hs = new Hashtable();
            for (int j = 0; j < i; j++)
            {
                hs.Add(Ran.Next(), Ran.Next());
            }
            return qu;
        }

        //public static void RemoveElementMyCollection(int i, int j, ref Stack stck)
        //{
        //    stck.Pop(i, j);
        //}

        public static void AddElementMyCollection(int i, ref Queue qu)
        {
            for (int j = 0; j < i; j++)
            {
                qu.Enqueue(Random());
            }
        }

        public static void PrintMyCollection(Queue qu)
        {
            foreach (double a in qu)
                Console.Write($"{a:0.00} ");
            Console.Write("\n");
        }
    }

    class Program
    {
        static void Main()
        {
            ArrayList col = MyArrayList.NewCollection(5);
            MyArrayList.PrintMyCollection(col);
            MyArrayList.AddElementMyCollection(10, ref col);
            MyArrayList.PrintMyCollection(col);
            MyArrayList.RemoveElementMyCollection(5, 1, ref col);
            MyArrayList.PrintMyCollection(col);
            Console.ReadKey();
        }
    }
}
