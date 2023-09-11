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

namespace RentaCar
{
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Customer save = new Customer();
                save.customerNameSurname = textBox1.Text;
                save.customerPhone = textBox2.Text;
                save.customerAge = Convert.ToInt32(textBox3.Text);
                save.customerBudget = Convert.ToDecimal(textBox4.Text);
                save.customerDownPayment = Convert.ToDecimal(textBox5.Text);
                coon.Customers.Add(save);
                coon.SaveChanges();
                MessageBox.Show("Başarıyla Kayıt Oldunuz");
                CustomerLogin git = new CustomerLogin();
                git.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!");
            }
            
        }
    }
}
