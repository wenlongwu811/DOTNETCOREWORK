using Shopping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form2 : Form
    {
        
        public Form2(OrderDetails orderDetails,Commodity[] comm)
        {
            InitializeComponent();
            this.orderDetails = orderDetails;
            this.comm = comm;
        }/// <summary>
        /// 用户执行增删改操作
        /// </summary>
        public OrderDetails orderDetails;
        public Commodity[] comm;
       /* Commodity SumApple = new Commodity("Apple", 5.0, 100);//库存
        Commodity SumBanana = new Commodity("Banana", 10, 50);
        Commodity SumGrape = new Commodity("Grape", 20, 60);
        Commodity SumMango = new Commodity("Mango", 9, 88);*/
        private int opt_man;
        private int opt_app;
        private int opt_ban;
        private int opt_gra;

        public int Opt_app { get => opt_app; set => opt_app = value; }
        public int Opt_ban { get => opt_ban; set => opt_ban = value; }
        public int Opt_gra { get => opt_gra; set => opt_gra = value; }
        public int Opt_man { get => opt_man; set => opt_man = value; }

        private void Form2_Load(object sender, EventArgs e)
        {
            Opt_app = 1;
            Opt_ban = 1;
            Opt_gra = 1;
            Opt_man = 1;
            App_txt.DataBindings.Add("Text",this,"Opt_app");
            Ban_txt.DataBindings.Add("Text", this, "Opt_ban");
            Gra_txt.DataBindings.Add("Text", this, "Opt_gra");
            Man_txt.DataBindings.Add("Text", this, "Opt_man");
        }
       // public event EventHandler AfterChange;
        protected override void OnClosing(CancelEventArgs e)
        {
           // AfterChange(orderDetails, EventArgs.Empty);
            base.OnClosing(e);
        }

        private void Sure_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DelApp_btn_Click(object sender, EventArgs e)
        {
            int n =int.Parse(App_txt.Text);
            if (n>orderDetails.Commodities[0].Num)
            {
                MessageBox.Show("您只有{0}个苹果." + orderDetails.Commodities[0].Num);
            }
            orderDetails.Commodities[0].Num -= n;
            comm[0].Num += n;
        }

        private void AddApp_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(App_txt.Text);
            if (n > comm[0].Num)
            {
                MessageBox.Show("苹果总数只有{0}个." + comm[0].Num);
            }
            orderDetails.Commodities[0].Num+=n;
            comm[0].Num -= n;
        }

        private void App_txt_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(App_txt.Text);
            if (n < 0) { MessageBox.Show("输入的必须是正数。"); }// 没考虑到小数情况
        }

        private void Ban_txt_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(Ban_txt.Text);
            if (n < 0) { MessageBox.Show("输入的必须是正数。"); }
        }

        private void Gra_txt_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(Gra_txt.Text);
            if (n < 0) { MessageBox.Show("输入的必须是正数。"); }
        }

        private void Man_txt_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(Man_txt.Text);
            if (n < 0) { MessageBox.Show("输入的必须是正数。"); }
        }

        private void AddBan_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Ban_txt.Text);
            if (n > comm[1].Num)
            {
                MessageBox.Show("香蕉总数只有{0}串." + comm[1].Num);
            }
            orderDetails.Commodities[1].Num += n;
            comm[1].Num -= n;
        }

        private void AddGra_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Gra_txt.Text);
            if (n > comm[2].Num)
            {
                MessageBox.Show("葡萄总数只有{0}串." + comm[2].Num);
            }
            orderDetails.Commodities[2].Num += n;
            comm[2].Num -= n;
        }

        private void AddMan_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Man_txt.Text);
            if (n > comm[3].Num)
            {
                MessageBox.Show("芒果总数只有{0}个." + comm[3].Num);
            }
            orderDetails.Commodities[3].Num += n;
            comm[3].Num -= n;
        }
        
        private void AppNum_txt_TextChanged(object sender, EventArgs e)
        {
            Text = "" + orderDetails.Commodities[0].Num;
        }

        private void BanNum_txt_TextChanged(object sender, EventArgs e)
        {
            Text = "" + orderDetails.Commodities[1].Num;
        }

        private void GraNum_txt_TextChanged(object sender, EventArgs e)
        {
            Text = "" + orderDetails.Commodities[2].Num;
        }

        private void ManNum_txt_TextChanged(object sender, EventArgs e)
        {
            Text = "" + orderDetails.Commodities[3].Num;
        }

        private void DelBan_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Ban_txt.Text);
            if (n > orderDetails.Commodities[1].Num)
            {
                MessageBox.Show("您只有{0}串香蕉." + orderDetails.Commodities[1].Num);
            }
            orderDetails.Commodities[1].Num -= n;
            comm[1].Num += n;
        }

        private void DelGra_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Gra_txt.Text);
            if (n > orderDetails.Commodities[2].Num)
            {
                MessageBox.Show("您只有{0}串葡萄." + orderDetails.Commodities[2].Num);
            }
            orderDetails.Commodities[2].Num -= n;
            comm[2].Num += n;
        }

        private void DelMan_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Man_txt.Text);
            if (n > orderDetails.Commodities[3].Num)
            {
                MessageBox.Show("您只有{0}个芒果." + orderDetails.Commodities[3].Num);
            }
            orderDetails.Commodities[3].Num -= n;
            comm[3].Num += n;
        }
    }
}
