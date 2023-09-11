using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Branchs : Form
    {
        public Branchs()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Branches.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["branchID"].Value.ToString();
            textBox1.Text = column.Cells["branchName"].Value.ToString();
            textBox2.Text = column.Cells["branchEmployeeCount"].Value.ToString();
            textBox3.Text = column.Cells["branchSalary"].Value.ToString();
            textBox4.Text = column.Cells["carStock"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Branch save = new Branch();
            save.branchName = textBox1.Text;
            save.branchEmployeeCount = Convert.ToInt32(textBox2.Text);
            save.branchSalary = Convert.ToDecimal(textBox3.Text);
            save.carStock = Convert.ToInt32(textBox4.Text);
            coon.Branches.Add(save);
            coon.SaveChanges();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var update = coon.Branches.Where(x=>x.branchID == ID).FirstOrDefault();
            update.branchName = textBox1.Text;
            update.branchEmployeeCount = Convert.ToInt32(textBox2.Text);
            update.branchSalary = Convert.ToDecimal(textBox3.Text);
            update.carStock = Convert.ToInt32(textBox4.Text);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Branches.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var delete = coon.Branches.Where(x => x.branchID == ID).FirstOrDefault();
            coon.Branches.Remove(delete);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Branches.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonelInterface geri = new PersonelInterface();
            geri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Branches.Where(x => x.branchName.Contains(textBox1.Text)).ToList();
        }
    }
}
