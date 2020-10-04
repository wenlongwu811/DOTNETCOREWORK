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

        public int orderID = 0;
        private Dictionary<int, OrderDetails> dic = new Dictionary<int, OrderDetails>();//用来对应每一个用户
        public static Commodity SumApple = new Commodity("Apple", 5.0, 100);//库存
        public static Commodity SumBanana = new Commodity("Banana", 10, 50);
        public static Commodity SumGrape = new Commodity("Grape", 20, 60);
        public static Commodity SumMango = new Commodity("Mango", 9, 88);
        Commodity[] comm = { SumApple, SumBanana, SumGrape, SumMango };
        public int OrderID { get => OrderID; set => OrderID = value; }
        public Dictionary<int, OrderDetails> Dic { get => dic; set => dic = value; }
        public int Index2 { get => index2; set => index2 = dataGridView2.CurrentRow.Index; }//获取用户details的ID，进而通过dic操作其用户对象
        public string S2 { get => s2; set => s2 = dataGridView2.Rows[index2].Cells["UserID"].Value.ToString(); }
        private int index2;
        private string s2;
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Rows[0].Frozen = true;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Rows[0].Frozen = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
            this.Controls.Add(dataGridView2);
            this.Controls.Add(AddOrder_btn);
            this.Controls.Add(Sel_txt); 
            this.Controls.Add(Del_Order_txt); 
            this.Controls.Add(ChangeCommodity_btn); 
            this.Controls.Add(label1);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Controls.Add(dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)//添加订单
        {
            OrderDetails orderDetails = new OrderDetails(OrderID++);
            Commodity Apple = new Commodity("Apple", 5.0, 0);//初始化的时候都为0
            Commodity Banana = new Commodity("Banana", 10, 0);
            Commodity Grape = new Commodity("Grape", 20, 0);
            Commodity Mango = new Commodity("Mango", 9, 0);
            orderDetails.commodities.Add(Apple);
            orderDetails.commodities.Add(Banana);
            orderDetails.commodities.Add(Grape);
            orderDetails.commodities.Add(Mango);
            Dic.Add(OrderID, orderDetails);
            int New_Index2 = dataGridView2.Rows.Add();//创建新行，初始值都为0
            dataGridView2.Rows[New_Index2].Cells[0].Value = "" + Dic[OrderID].OrderID;
            dataGridView2.Rows[New_Index2].Cells[1].Value = "" + 0;
            dataGridView2.Rows[New_Index2].Cells[2].Value = "" + 0;
            dataGridView2.Rows[New_Index2].Cells[3].Value = "" + 0;
            dataGridView2.Rows[New_Index2].Cells[4].Value = "" + 0;
            int New_Index1 = (OrderID / 10)+1;//每十个在dataGridView的一行中；
            if (New_Index1 > dataGridView1.Rows.Count)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[New_Index1].Cells[0].Value = "" + New_Index1;//New_Index 就是表一的每一行ID
            dataGridView1.Rows[New_Index1].Cells[1].Value = "" + OrderID % 10;//得到这一页有多少个；
        }

        private void button1_Click(object sender, EventArgs e)//点购商品
        {
            int num = int.Parse(S2);
            Form2 form2 = new Form2(Dic[num],comm);
            if (form2.ShowDialog() ==DialogResult.OK )
            {
                form2.AfterChange += new EventHandler(this.AfterChange);
                this.comm = form2.comm;
            }//增删改完成后，更新用户信息 
            dataGridView2.Rows[num].Cells[1].Value = "" + Dic[num].Commodities[0];
            dataGridView2.Rows[num].Cells[2].Value = "" + Dic[num].Commodities[1];
            dataGridView2.Rows[num].Cells[3].Value = "" + Dic[num].Commodities[2];
            dataGridView2.Rows[num].Cells[4].Value = "" + Dic[num].Commodities[3];
        }
        private void AfterChange(object sender, EventArgs e)
        {
            int num = int.Parse(S2);
            Dic[num] = sender as OrderDetails;
        }

        private void Sel_txt_TextChanged(object sender, EventArgs e)
        {
            this.Sel_txt.TextChanged +=new EventHandler (this.Sel_txt_TextChanged);
            this.Sel_txt.KeyDown +=new KeyEventHandler(this.Sel_txt_KeyDown);
        }

        private void Sel_txt_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable rentTable = (DataTable)dataGridView2.DataSource;
            if(e.KeyValue == 13)//press Enter
            {
                int result;
                if (int.TryParse(Sel_txt.Text,out result))
                {
                    for (int i = 0; i < rentTable.Rows.Count; i++)
                    {
                        if (rentTable.Rows[i]["UserID"].ToString()==Sel_txt.Text)
                        {
                            dataGridView2.Rows[i].Selected = true;
                            dataGridView2.FirstDisplayedScrollingRowIndex = i;
                            return;
                        }
                    }
                    MessageBox.Show("用户不存在！", "提示");
                }
            }
            MessageBox.Show("请输入UserID", "提示");
        }

        private void Sel_txt_TextChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Del_Order_txt_Click(object sender, EventArgs e)
        {
            DataTable rentTable = (DataTable)dataGridView2.DataSource;
            for (int i = 0; i < rentTable.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected == true)
                {
                    int n = int.Parse(dataGridView2.Rows[i].Cells[0].ToString());
                    dic.Remove(n);
                    dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                    return;
                }
            }
        }

       
    }
}
