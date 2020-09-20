using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Rectangle:Figure_Base
    {
        int length, width;
        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }
        public override bool Is_Legal()
        {
            if (length <= 0 || width <= 0){ return false;}
            return true;
        }
        public override double Area()
        {
            return (double)(length * width);
        }
    }
}
