using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumArea = 0;
            for (int i = 0; i < 3; i++)
            {
               Figure_Base figure;
                Console.WriteLine("你想生产的是Rectangle 还是 Triangle：");
                string s = Console.ReadLine();
                Console.WriteLine("请输入长和宽或者是三边长：");
                string m = Console.ReadLine();
                string[] arr = m.Split(" ");
                int[] side = Array.ConvertAll<string, int>(arr, n => int.Parse(n));
                if (s=="Rectangle")
                {
                    figure =  FigureFactory.CreateFigure(FigureType.Rectangle, side);
                   
                }
                else
                {
                     figure = FigureFactory.CreateFigure(FigureType.Triangle, side);

                }
                sumArea += figure.Area();
            }
            Console.WriteLine("总面积是{0}",sumArea);
        }
    }
}
