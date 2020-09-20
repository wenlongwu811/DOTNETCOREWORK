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
        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
        }
        public override bool Is_Legal()
        {
            if (Length <= 0 || Width <= 0){ return false;}
            return true;
        }
        public override double Area()
        {
            return (double)(Length * Width);
        }
    }
}
