using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class FigureFactory
    {
        public static Figure_Base CreateFigure(FigureType type,int[] side)
        {
            Figure_Base figure = null;
            switch (type)
            {
                case FigureType.Triangle: figure = new Triangle(side[0], side[1], side[2]);
                    break;
                case FigureType.Rectangle:figure = new Rectangle(side[0],side[1]);
                    break;
                default:
                    break;
            }
            return figure;
        }
    }
}
