﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AlgorithmPractice
{
   public class Program : Methods
    {


        public static void Main(string[] args)
        {
            int[] Arr = { 2, 4, 3, 5, 10, 8, 9, 15, 20, 17, 16, 1, 6, 14, 19, 11, 13, 18, 7, 12 };
          //  Waiting();
           // ThreadCount(Arr);
            //Waiting();
            //ThreadCount2(Arr);
            //InsertionSort(Arr);
            //SelectionSort(Arr);
            Console.ReadKey();
            
        }


    }


    public class Methods
    {

        //public static void ThreadCount(int[] Arr)
        //{

        //    Stopwatch Select = Stopwatch.StartNew();
        //    Thread T1 = new Thread(new ThreadStart(() => SelectionSort(Arr)));
        //    T1.Start();

        //    Select.Stop();

        //    Console.Write(String.Format(" Time taken: {0}ms, ", T1.IsAlive.ToString()));




        //}
        //public static void ThreadCount2(int[] Arr)
        //{
        //    Stopwatch Insert = Stopwatch.StartNew();
        //    Thread T2 = new Thread(Thread.BeginThreadAffinity);
        //    InsertionSort(Arr);
        //    Insert.Stop();
        //    Console.Write(" Time taken: {0}ms, ", Insert.Elapsed.TotalMilliseconds);
        //}
        //public static void Waiting()
        //{

        //    int Co = 5000;

        //    Console.WriteLine("Calculating Please Wait..");
        //    Parallel.Invoke(() => Thread.Sleep(Co),
        //    () => For());
        //    if (Thread.CurrentThread == )
        //    {

        //    }

        //}
        //public static void For()
        //{
        //    string Loading = "Loading";

        //    Stopwatch WaitWatch = Stopwatch.StartNew();
        //    WaitWatch.Start();
        //    var SecondCounter = WaitWatch.Elapsed.TotalSeconds;
        //    if (SecondCounter == 30)
        //    {

        //    }
        //    drawTextProgressBar(Loading, SecondCounter, 30);
        //    WaitWatch.Stop();


        //}



        //public static void drawTextProgressBar(string stepDescription, double progress, int total)
        //{
        //    int totalChunks = 30;

        //    //draw empty progress bar
        //    Console.CursorLeft = 0;
        //    Console.Write("["); //start
        //    Console.CursorLeft = totalChunks + 1;
        //    Console.Write("]"); //end
        //    Console.CursorLeft = 1;

        //    double pctComplete = Convert.ToDouble(progress) / total;
        //    int numChunksComplete = Convert.ToInt16(totalChunks * pctComplete);

        //    //draw completed chunks
        //    Console.BackgroundColor = ConsoleColor.Green;
        //    Console.Write("".PadRight(numChunksComplete));

        //    //draw incomplete chunks
        //    Console.BackgroundColor = ConsoleColor.Gray;
        //    Console.Write("".PadRight(totalChunks - numChunksComplete));

        //    //draw totals
        //    Console.CursorLeft = totalChunks + 5;
        //    Console.BackgroundColor = ConsoleColor.Black;

        //    string output = progress.ToString() + " of " + total.ToString();
        //    Console.Write(output.PadRight(15) + stepDescription); //pad the output so when changing from 3 to 4 digits we avoid text shifting
        //}

        //public static void SelectionSort(int[] arr)
        //{
        //    Console.WriteLine("Selection Sort: ");
        //    int Posmin;
        //    int Temp;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Posmin = i;
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {

        //            if (arr[j] < arr[Posmin])
        //            {
        //                Posmin = j;
        //            }
        //        }
        //        if (Posmin != i)
        //        {
        //            Temp = arr[i];
        //            arr[i] = arr[Posmin];
        //            arr[Posmin] = Temp;
        //        }
        //        Console.Write(String.Format("{0}, ", arr[i]));
        //    }

        //}

        //public static void InsertionSort(int[] Arr)
        //{
        //    Console.WriteLine("\nInsertion Sort: ");
        //    for (int i = 1; i < Arr.Length; i++)
        //    { int Temp = Arr[i];
        //        int j = i;
        //        while ((j > 0) && (Arr[j - 1] > Temp))
        //        {
        //            Arr[j] = Arr[j - 1];
        //            j--;
        //            Arr[j] = Temp;
        //        }
        //    }
        //    foreach (int val in Arr)
        //    {
        //        Console.Write(val + ", ");
        //    }
        //}

        public static void Reverse()
        {
           
            string w = "War Hero";
            string[] Words = w.Split(" ");
           
           
            

        }
        
    }

}