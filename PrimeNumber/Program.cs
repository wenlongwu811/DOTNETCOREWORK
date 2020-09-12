using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PrimeNumber
{
    class Program
    {
        static bool IfPriNum(int i)
        {
            if (i == 1) { return false; }
            int j = 2;
            while (j * j <= i)
            {
                if (i % j == 0)
                {
                    return false;
                }
                j++;
            }
            return true;
        }

        static List<int> Divisor(int p)//采用连除法，如果不是为了方便求素数因子，就应该每整除一次，除数和结果都要保存，但是为了作为模板，我还是麻烦一点写成两个都保存
        {
            List<int> list = new List<int>();
            int q;
            for (int i = 1; i * i < p; i++)
            {
                if (p % i != 0) { continue; }
                q = p / i;//避免隐式转换带来影响1=3/2
                list.Add(i);//存除数
                if (q == i) { continue; }//保证数据唯一性
                list.Add(q);//存结果
            }
            return list;
        }

        static void Main(string[] args)
        {
            Console.Write("请输入数字num = ");
            string s;
            s = Console.ReadLine();
            int num;
            List<int> primenum = new List<int>();//存储素数因子
            num = int.Parse(s);
            List<int> list = Divisor(num);
            Console.Write("以下是num所有的素数因子：");
            foreach (var i in list)
            {
                if (!IfPriNum(i)) { continue; }
                Console.Write("{0} ", i);
                primenum.Add(i);
            }

        }
    }
}
