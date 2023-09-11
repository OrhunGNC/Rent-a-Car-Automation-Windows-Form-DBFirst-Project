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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        public bool CLogin(string namesurname,string phone)
        {
            var query = from user in coon.Customers where user.customerNameSurname == namesurname && user.customerPhone == phone select user;
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CLogin(textBox1.Text, textBox2.Text))
            {
                CustomerInterface customerint = new CustomerInterface();
                customerint.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Bilgileri");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CustomerRegister register = new CustomerRegister();
            register.Show();
            this.Hide();
        }
    }
}
