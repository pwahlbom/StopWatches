using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StopWatches
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new List<int>();
            var b = new Random();
            for (int i = 0; i < 1000; i++)
            {
                a.Add(b.Next(1000));
            }
            var c = new Stopwatch();
            var d = 0;
            c.Start();
            //for (int i = 0; i < 1000; i++)
            foreach (int num1 in a)
            {
                d = 0;
                //for (int x = 0; x < 1000; x++)
                foreach (int num2 in a)
                {
                    if (a[i] == a[x])
                    {
                        d++;
                    }
                }
                Console.WriteLine(string.Format("{0}:{1}", a[i], d));
            }
            c.Stop();
            Console.WriteLine(string.Format("The process took {0} ticks.", c.ElapsedMilliseconds));
            Console.ReadLine();


            //foreach (int num1 in numberList)
            //{
            //    var dups = 0;

            //    foreach (int num2 in numberList)
            //    {
            //        if (num1 == num2)
            //        {
            //            dups++;
            //        }

            //    }
            //    Console.WriteLine(string.Format("{0}:{1}", num1, dups));
            //}
        }
    }
}
