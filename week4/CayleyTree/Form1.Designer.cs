namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lable1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDegree1 = new System.Windows.Forms.TextBox();
            this.txtDegree2 = new System.Windows.Forms.TextBox();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(687, 85);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(67, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "画笔颜色";
            this.lable1.Click += new System.EventHandler(this.lable1_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(698, 401);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 7;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(521, 77);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 23);
            this.cbxColor.TabIndex = 8;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "右分支角度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(687, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "左分支角度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(687, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "右分支长度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(687, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "左分支长度";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(687, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "递归深度";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(687, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "主干长度";
            // 
            // txtDegree1
            // 
            this.txtDegree1.Location = new System.Drawing.Point(521, 144);
            this.txtDegree1.Name = "txtDegree1";
            this.txtDegree1.Size = new System.Drawing.Size(100, 25);
            this.txtDegree1.TabIndex = 15;
            this.txtDegree1.TextChanged += new System.EventHandler(this.txtDegree1_TextChanged);
            // 
            // txtDegree2
            // 
            this.txtDegree2.Location = new System.Drawing.Point(521, 182);
            this.txtDegree2.Name = "txtDegree2";
            this.txtDegree2.Size = new System.Drawing.Size(100, 25);
            this.txtDegree2.TabIndex = 16;
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(521, 218);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(100, 25);
            this.txtPer1.TabIndex = 17;
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(521, 249);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(100, 25);
            this.txtPer2.TabIndex = 18;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(521, 291);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 25);
            this.txtN.TabIndex = 19;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(521, 347);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 25);
            this.txtLength.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtPer2);
            this.Controls.Add(this.txtPer1);
            this.Controls.Add(this.txtDegree2);
            this.Controls.Add(this.txtDegree1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDegree1;
        private System.Windows.Forms.TextBox txtDegree2;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtLength;
    }
}

