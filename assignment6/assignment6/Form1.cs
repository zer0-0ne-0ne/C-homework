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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Order> orders = new List<Order>();
        int cnt = 0;

        private void OpenNewForm(object sender, EventArgs e)
        {
            cnt++;
            Form2 newform = new Form2();
            newform.Show();
            Order newo = newform.o;
            newo.Id = cnt;
            orders.Add(newo);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var os in orders)
            {
                int currentindex = dataGridView1.Rows.Add();
                dataGridView1.Rows[currentindex].Cells["Column1"].Value = os.Id;
                dataGridView1.Rows[currentindex].Cells["Column2"].Value = os.Customer.Name;
                dataGridView1.Rows[currentindex].Cells["Column3"].Value = os.Customer.Id;
                dataGridView1.Rows[currentindex].Cells["Column4"].Value = os.CreateTime;
                dataGridView1.Rows[currentindex].Cells["Column5"].Value = os.TotalPrice;
            }
            
        }
    }
}
