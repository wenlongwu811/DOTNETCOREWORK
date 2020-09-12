using System;
using System.Collections.Generic;

namespace aishisuanfa
{
    class Program
    {
        const int N = 101;
        static List<int> Ans(int n)
        {
            List<int> list = new List<int>();
            bool[] is_prime = new bool[n + 1];
            for (int i = 2; i <n+1 ; i++)
            {
                is_prime[i] = true;
            }
            for (int i = 2; i < n+1 ; i++)
            {
                if (!is_prime[i]) { continue; }
                list.Add(i);
                for (int j = 2*i; j < n; j+=i)
                {
                    is_prime[i] = false;
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            Console.Write("输入0-100以内的数字num：");
            string s = Console.ReadLine();
            int num = int.Parse(s);
            List<int> list = Ans(num);
            Console.Write("{0}以内的素数：");
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
