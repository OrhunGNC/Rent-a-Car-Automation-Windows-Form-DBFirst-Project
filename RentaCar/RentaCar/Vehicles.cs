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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Vehicles.ToList();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle save = new Vehicle();
            save.vehiclePrice = Convert.ToDecimal(textBox1.Text);
            save.vehicleNumberPlate = Convert.ToInt32(textBox2.Text);
            save.vehicleBrand = textBox3.Text;
            save.vehicleModel = textBox4.Text;
            save.vehicleYear = textBox5.Text;
            save.vehicleMotor = textBox6.Text;
            save.vehiclePackage = textBox7.Text;
            save.vehicleColor = textBox8.Text;
            save.vehicleGear = textBox9.Text;
            save.customerID = Convert.ToInt32(textBox10.Text);
            save.branchID = Convert.ToInt32(textBox11.Text);
            coon.Vehicles.Add(save);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Vehicles.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var update = coon.Vehicles.Where(x => x.vehicleID == ID).FirstOrDefault();
            update.vehiclePrice = Convert.ToDecimal(textBox1.Text);
            update.vehicleNumberPlate = Convert.ToInt32(textBox2.Text);
            update.vehicleBrand = textBox3.Text;
            update.vehicleModel = textBox4.Text;
            update.vehicleYear = textBox5.Text;
            update.vehicleMotor = textBox6.Text;
            update.vehiclePackage = textBox7.Text;
            update.vehicleColor = textBox8.Text;
            update.vehicleGear = textBox9.Text;
            update.customerID = Convert.ToInt32(textBox10.Text);
            update.branchID = Convert.ToInt32(textBox11.Text);
            coon.SaveChanges();
            dataGridView1.DataSource= coon.Vehicles.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var delete = coon.Vehicles.Where(x => x.vehicleID == ID).FirstOrDefault();
            coon.Vehicles.Remove(delete);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Vehicles.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonelInterface geri = new PersonelInterface();
            geri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Vehicles.Where(x => x.vehicleBrand.Contains(textBox3.Text)).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Vehicles.Where(x => x.vehicleModel.Contains(textBox4.Text)).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
