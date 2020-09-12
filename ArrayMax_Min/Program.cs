using System;
using System.Collections;

namespace ArrayMax_Min
{
    class Program
    {
        static void Man_Min(int[] arr, out int max, out int min, out int sum, out double ver)
        {
            max = arr[0];
            min = arr[0];
            sum = arr[0];
            int t, i = 1;
            while (i < arr.Length)
            {
                t = arr[i];
                sum += t;
                if (t >= max)
                {
                    max = t;
                }
                else
                {
                    if (t <= min)
                    {
                        min = t;
                    }
                }
                i++;
            }
            ver = sum / arr.Length;
        }
        static void Main(string[] args)
        {
            Console.Write("请输入数组元素 ");
            // ArrayList Arr = new ArrayList();
            char[] s = new char[] { ' ' };
            string[] arr = Console.ReadLine().Split(s);//Split(params char[]? separator)以空格为分隔符切割成n+1份
            int[] arry1 = new int[arr.Length];
            arry1 = Array.ConvertAll<string, int>(arr, m => int.Parse(m));//使用lambda函数，将arr里的string强制转换成int
            Man_Min(arry1, out int max, out int min, out int sum, out double ver);
            Console.Write("sum = {0} , max = {1}, min = {2},ver = {3}. ", sum, max, min, ver);
        }
    }
}


