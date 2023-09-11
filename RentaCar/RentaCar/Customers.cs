using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Customers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["customerID"].Value.ToString();
            textBox1.Text = column.Cells["customerNameSurname"].Value.ToString();
            textBox2.Text = column.Cells["customerPhone"].Value.ToString();
            textBox3.Text = column.Cells["customerAge"].Value.ToString();
            textBox4.Text = column.Cells["customerBudget"].Value.ToString();
            textBox5.Text = column.Cells["customerDownPayment"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var update = coon.Customers.Where(x => x.customerID == ID).FirstOrDefault();
            update.customerNameSurname = textBox1.Text;
            update.customerPhone = textBox2.Text;
            update.customerAge = Convert.ToInt32(textBox3.Text);
            update.customerBudget = Convert.ToDecimal(textBox4.Text);
            update.customerDownPayment = Convert.ToDecimal(textBox5.Text);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Customers.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonelInterface geri = new PersonelInterface();
            geri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Customers.Where(x => x.customerNameSurname.Contains(textBox1.Text)).ToList();
        }
    }
}
