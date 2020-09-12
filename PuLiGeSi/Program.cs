using System;
namespace PuLiGeSi
{
    class Program
    {
        public static int IsToeplitzMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); ++row)
            {
                for (int col = 0; col < matrix.GetLength(1); ++col)
                {
                    if (row > 0 && col > 0 && matrix[row, col] != matrix[row - 1, col - 1])
                        return 0;
                }
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int M, N;
            Console.Write("请输入M= ");
            string s = Console.ReadLine();
            M = int.Parse(s);
            Console.Write("请输入N= ");
            s = Console.ReadLine();
            N = int.Parse(s);
            int[,] matrix = new int[M, N];
            Console.WriteLine("请输入矩阵:");
            for (int i = 0; i < M; i++)
            {
                int[] e = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);/*每一行的数据，用一个一维数组来存储*/
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = e[j];/*读入*/
                }

            }//得到一个矩阵
            if (IsToeplitzMatrix(matrix) == 1)
            {
                Console.WriteLine("True!");
            }
            else
            {
                Console.WriteLine("False!");
            }
        }
    }
}

