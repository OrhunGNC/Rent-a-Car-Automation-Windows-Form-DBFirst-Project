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
    public partial class Personels : Form
    {
        public Personels()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Personels.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["personelID"].Value.ToString();
            textBox1.Text = column.Cells["personelNameSurname"].Value.ToString();
            textBox2.Text = column.Cells["personelPhone"].Value.ToString();
            textBox3.Text = column.Cells["personelTitle"].Value.ToString();
            textBox4.Text = column.Cells["personelMail"].Value.ToString();
            textBox5.Text = column.Cells["personelWage"].Value.ToString();
            textBox6.Text = column.Cells["branchID"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var delete = coon.Personels.Where(x => x.personelID == ID).FirstOrDefault();
            coon.Personels.Remove(delete);
            coon.SaveChanges();
            dataGridView1.DataSource= coon.Personels.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var update = coon.Personels.Where(x => x.personelID == ID).FirstOrDefault();
            update.personelNameSurname = textBox1.Text;
            update.personelPhone = textBox2.Text;
            update.personelTitle = textBox3.Text;
            update.personelMail = textBox4.Text;
            update.personelWage = Convert.ToDecimal(textBox5.Text);
            update.branchID = Convert.ToInt32(textBox6.Text);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Personels.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonelInterface geri = new PersonelInterface();
            geri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Personels.Where(x => x.personelNameSurname.Contains(textBox1.Text)).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Personels_Load(object sender, EventArgs e)
        {

        }
    }
}
