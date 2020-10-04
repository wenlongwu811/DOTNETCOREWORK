using Shopping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int orderID;
        private Dictionary<int, OrderDetails> dic = new Dictionary<int, OrderDetails>();//用来对应每一个用户
        public static Commodity SumApple = new Commodity("Apple", 5.0, 100);//库存
        public static Commodity SumBanana = new Commodity("Banana", 10, 50);
        public static Commodity SumGrape = new Commodity("Grape", 20, 60);
        public static Commodity SumMango = new Commodity("Mango", 9, 88);
        Commodity[] comm = { SumApple, SumBanana, SumGrape, SumMango };
        //public int OrderID { get => OrderID; set => OrderID = value; }
        public Dictionary<int, OrderDetails> Dic { get => dic; set => dic = value; }
        //public int Index2 { get => index2; set => index2 = dataGridView2.CurrentRow.Index; }//获取用户details的ID，进而通过dic操作其用户对象
        //public string S2 { get => s2; set => s2 = dataGridView2.Rows[Index2].Cells[0].Value.ToString(); }
        //private int index2;
        //private string s2;
      

        private void Form1_Load(object sender, EventArgs e)
        {
            orderID = 0;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Controls.Clear();
            Controls.Add(dataGridView2);
            Controls.Add(AddOrder_btn);
            Controls.Add(Sel_txt); 
            Controls.Add(Del_Order_txt); 
            Controls.Add(ChangeCommodity_btn); 
            Controls.Add(label1);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Controls.Clear();
            Controls.Add(dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)//添加订单
        {
            OrderDetails orderDetails = new OrderDetails(orderID++);
            Commodity Apple = new Commodity("Apple", 5.0, 0);//初始化的时候都为0
            Commodity Banana = new Commodity("Banana", 10, 0);
            Commodity Grape = new Commodity("Grape", 20, 0);
            Commodity Mango = new Commodity("Mango", 9, 0);
            orderDetails.commodities.Add(Apple);
            orderDetails.commodities.Add(Banana);
            orderDetails.commodities.Add(Grape);
            orderDetails.commodities.Add(Mango);
            Dic.Add(orderID, orderDetails);//实际上这个Key比userID小1，是之前的++倒置的
            int New_Index2 = dataGridView2.Rows.Add();//创建新行，初始值都为0
            dataGridView2.Rows[New_Index2].Cells[0].Value = "" + Dic[orderID].OrderID;
            dataGridView2.Rows[New_Index2].Cells[1].Value = "" + 0;
            dataGridView2.Rows[New_Index2].Cells[2].Value = "" + 0;
            dataGridView2.Rows[New_Index2].Cells[3].Value = "" + 0;
            dataGridView2.Rows[New_Index2].Cells[4].Value = "" + 0;
            int New_Index1 = (orderID / 10)+1;//每十个在dataGridView的一行中；
            if (New_Index1 > dataGridView1.Rows.Count-1)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[New_Index1].Cells[0].Value = "" + New_Index1;//New_Index 就是表一的每一行ID
            dataGridView1.Rows[New_Index1].Cells[1].Value = "" + orderID % 10;//得到这一页有多少个；
        }

        private void button1_Click(object sender, EventArgs e)//点购商品
        {
            int index2 = dataGridView2.CurrentRow.Index;
            string s = dataGridView2.Rows[index2].Cells[0].Value.ToString();
            int num = Convert.ToInt32(s);
            Form2 form2 = new Form2(Dic[num],comm);
            if (form2.ShowDialog() ==DialogResult.OK )
            {
                //form2.AfterChange += new EventHandler(this.AfterChange);
                this.comm = form2.comm;
                Dic[num] = form2.orderDetails;
            }//增删改完成后，更新用户信息 
            dataGridView2.Rows[num].Cells[1].Value = "" + Dic[num].Commodities[0].Num;
            dataGridView2.Rows[num].Cells[2].Value = "" + Dic[num].Commodities[1].Num;
            dataGridView2.Rows[num].Cells[3].Value = "" + Dic[num].Commodities[2].Num;
            dataGridView2.Rows[num].Cells[4].Value = "" + Dic[num].Commodities[3].Num;
        }
        /*private void AfterChange(object sender, EventArgs e)
        {
            int index2 = dataGridView2.CurrentRow.Index;
            string s = dataGridView2.Rows[index2].Cells[0].Value.ToString();
            int num = Convert.ToInt32(s);
            Dic[num] = sender as OrderDetails;
        }*/

        private void Sel_txt_TextChanged(object sender, EventArgs e)
        {
            this.Sel_txt.TextChanged +=new EventHandler (this.Sel_txt_TextChanged);
            this.Sel_txt.KeyDown +=new KeyEventHandler(this.Sel_txt_KeyDown);
        }

        private void Sel_txt_KeyDown(object sender, KeyEventArgs e)
        {
            //DataTable rentTable = (DataTable)dataGridView2.DataSource;
            if(e.KeyValue == 13)//press Enter
            {
                int result;
                if (int.TryParse(Sel_txt.Text,out result))
                {
                    for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString()==Sel_txt.Text)
                        {
                            dataGridView2.Rows[i].Selected = true;
                            dataGridView2.FirstDisplayedScrollingRowIndex = i;
                            return;
                        }
                    }
                    MessageBox.Show("用户不存在！", "提示");
                }
            }
            //MessageBox.Show("请输入UserID", "提示");
        }

        private void Sel_txt_TextChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Del_Order_txt_Click(object sender, EventArgs e)
        {
            //DataTable rentTable = (DataTable)dataGridView2.DataSource;
            for (int i = 1; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected == true)
                {
                    int n = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    dic.Remove(n);
                    dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                    return;
                }
            }
        }

       
    }
}
