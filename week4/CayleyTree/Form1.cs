using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double degree1;
        private double degree2;
        private Pen drawPen;
        private double per1;
        private double per2;
        private int n;
        private int length;
        private Graphics graphics;

        public Pen DrawPen { get => drawPen; set => drawPen = value; }
        public double Degree1 { get => degree1; set => degree1 = value; }
        public double Degree2 { get => degree2; set => degree2 = value; }
        public double Per1 { get => per1; set => per1 = value; }
        public double Per2 { get => per2; set => per2 = value; }
        public int N { get => n; set => n = value; }
        public int Length { get => length; set => length = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            else { graphics.Clear(this.BackColor);/*graphics.Dispose();*/ }

            DrawCayleyTree(N, 200, 310, Length, -Math.PI / 2);

        }
        void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, Per1 * leng, th + Degree1 * Math.PI / 180);
            DrawCayleyTree(n - 1, x1, y1, Per2 * leng, th - Degree2 * Math.PI / 180);
        }
       
        void DrawLine(double x0,double y0,double x1,double y1)
        { 
            graphics.DrawLine(DrawPen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        
        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void txtDegree1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Degree1 = 30;
            Degree2 = 20;
            Per1 = 0.6;
            Per2 = 0.7;
            DrawPen = Pens.Red;
            N = 10;
            Length = 100;
            Pen[] pens = { Pens.Red, Pens.Green, Pens.Yellow };
            cbxColor.DataSource = pens;
            cbxColor.DisplayMember = "Color";
            cbxColor.DataBindings.Add("SelectedItem", this, "DrawPen");
            txtDegree1.DataBindings.Add("Text", this, "Degree1");
            txtDegree2.DataBindings.Add("Text", this, "Degree2");
            txtPer1.DataBindings.Add("Text", this, "Per1");
            txtPer2.DataBindings.Add("Text", this, "Per2");
            txtN.DataBindings.Add("Text", this, "N");
            txtLength.DataBindings.Add("Text", this, "Length");
        }
    }
}
