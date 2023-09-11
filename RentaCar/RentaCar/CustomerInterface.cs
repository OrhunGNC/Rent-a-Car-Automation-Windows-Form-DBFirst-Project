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
    public partial class CustomerInterface : Form
    {
        public CustomerInterface()
        {
            InitializeComponent();
        }

        RentaCarEntities coon = new RentaCarEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Branches.ToList();
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = coon.Vehicles.ToList();
            textBox2.Show();
            textBox3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Branches.Where(x => x.branchName.Contains(textBox1.Text)).ToList();
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = coon.Vehicles.Where(x => x.vehicleBrand.Contains(textBox2.Text)).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = coon.Vehicles.Where(x => x.vehicleModel.Contains(textBox3.Text)).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
