using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<OrderDetail> odlist = new List<OrderDetail>();
        public Order o = new Order();

        int price = 0;//单价
        int num = 0;//单个数量
        int total = 0;//单次总价
        int cnt = 0;//订单号

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0: price = 4; break;
                case 1: price = 2; break;
                case 2: price = 5; break;
                case 3: price = 1; break;
                case 4: price = 3; break;
            }
            pricetext.Text = price.ToString();
            total = price * num;
            totaltext.Text = total.ToString();
        }

        private void numtext_TextChanged(object sender, EventArgs e)
        {
            int a;
            if(int.TryParse(numtext.Text,out a))
            {
                num = int.Parse(numtext.Text);
            }
            total = price * num;
            totaltext.Text = total.ToString();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void addbutton_MouseClick(object sender, MouseEventArgs e)
        {
            Product p = new Product(price, comboBox2.SelectedItem.ToString(), price);
            OrderDetail od = new OrderDetail(p, num);
            odlist.Add(od);
            int currentindex = dataGridView2.Rows.Add();
            dataGridView2.Rows[currentindex].Cells["c1"].Value = comboBox2.SelectedItem.ToString();
            dataGridView2.Rows[currentindex].Cells["c2"].Value = num;
            dataGridView2.Rows[currentindex].Cells["c3"].Value = total;
        }

        private void createbutton_MouseClick(object sender, MouseEventArgs e)
        {
            cnt++;
            int id = int.Parse(customerid.Text);
            string name = customername.Text;
            Customer c = new Customer(id, name);
            o.Customer = c;
            o.CreateTime = DateTime.Now;
            foreach (var od in odlist) o.AddDetails(od);
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dataGridView2.Rows.RemoveAt(e.RowIndex);//移除一行
            }
        }
    }
}
