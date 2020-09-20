using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    class Triangle:Figure_Base
    {
        int side1, side2, side3;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }
        public Triangle(int side1,int side2,int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double Area()
        {
            int p = (side1 + side2 + side3) / 2;
            int q = p * (p - side1) * (p - side2)*(p - side3);
            return Math.Sqrt(q);
        }
        public override bool Is_Legal()
        {
            if ((side1+side2)>side3)
            {
                if ((side2+side3)>side1)
                {
                    if ((side1+side3)>side2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
