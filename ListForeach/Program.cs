using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerecType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数组：");
            Test2();
        }
        private static void Test2()
        {
            //list.ForEach(new Action<string>(PrintItem));
            List<int> list = new List<int>();
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            int[] array = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(array[i]);
            }
            int max = list[0];
            int min = list[0];
            int sum = 0;
            list.ForEach((x) =>
            {
                Console.WriteLine(x);
                max = Math.Max(max, x);
                min = Math.Min(min, x);
                sum += x;
            });
            Console.Write($"\nMax: {max}\nMin: {min}\nSum: {sum}");
            //list.ForEach(item => Console.WriteLine("item"))
        }
    }
}