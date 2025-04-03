namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.numtext = new System.Windows.Forms.TextBox();
            this.totaltext = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.customername = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.TextBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(374, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 28);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "产品名称";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(480, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 28);
            this.textBox9.TabIndex = 1;
            this.textBox9.Text = "产品单价";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(587, 12);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 28);
            this.textBox10.TabIndex = 2;
            this.textBox10.Text = "产品数量";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(692, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 28);
            this.textBox11.TabIndex = 3;
            this.textBox11.Text = "总金额";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "苹果",
            "香蕉",
            "西瓜",
            "葡萄",
            "橙子"});
            this.comboBox2.Location = new System.Drawing.Point(374, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 26);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(480, 46);
            this.pricetext.Name = "pricetext";
            this.pricetext.ReadOnly = true;
            this.pricetext.Size = new System.Drawing.Size(100, 28);
            this.pricetext.TabIndex = 5;
            // 
            // numtext
            // 
            this.numtext.Location = new System.Drawing.Point(587, 45);
            this.numtext.Name = "numtext";
            this.numtext.Size = new System.Drawing.Size(100, 28);
            this.numtext.TabIndex = 6;
            this.numtext.TextChanged += new System.EventHandler(this.numtext_TextChanged);
            // 
            // totaltext
            // 
            this.totaltext.Location = new System.Drawing.Point(692, 46);
            this.totaltext.Name = "totaltext";
            this.totaltext.ReadOnly = true;
            this.totaltext.Size = new System.Drawing.Size(100, 28);
            this.totaltext.TabIndex = 7;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(374, 79);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(418, 30);
            this.addbutton.TabIndex = 8;
            this.addbutton.Text = "添加";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addbutton_MouseClick);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 12);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 28);
            this.textBox12.TabIndex = 9;
            this.textBox12.Text = "顾客名称";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(118, 12);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 28);
            this.textBox13.TabIndex = 10;
            this.textBox13.Text = "顾客ID";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(12, 46);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(100, 28);
            this.customername.TabIndex = 11;
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(118, 45);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(100, 28);
            this.customerid.TabIndex = 12;
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(12, 79);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(206, 30);
            this.createbutton.TabIndex = 13;
            this.createbutton.Text = "创建";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createbutton_MouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(660, 245);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // c1
            // 
            this.c1.HeaderText = "产品名称";
            this.c1.MinimumWidth = 8;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 150;
            // 
            // c2
            // 
            this.c2.HeaderText = "产品数量";
            this.c2.MinimumWidth = 8;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Width = 150;
            // 
            // c3
            // 
            this.c3.HeaderText = "总金额";
            this.c3.MinimumWidth = 8;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 150;
            // 
            // c4
            // 
            this.c4.HeaderText = "移除";
            this.c4.MinimumWidth = 8;
            this.c4.Name = "c4";
            this.c4.Width = 150;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(799, 372);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.totaltext);
            this.Controls.Add(this.numtext);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "创建订单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.TextBox numtext;
        private System.Windows.Forms.TextBox totaltext;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox customername;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewButtonColumn c4;
    }
}