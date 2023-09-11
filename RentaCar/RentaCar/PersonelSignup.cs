using Microsoft.Win32.SafeHandles;
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
    public partial class PersonelSignup : Form
    {
        public PersonelSignup()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        private void PersonelSignup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Personel save = new Personel();
                save.personelNameSurname = textBox1.Text;
                save.personelPhone = textBox2.Text;
                save.personelTitle = textBox3.Text;
                save.personelMail = textBox4.Text;
                save.personelWage = Convert.ToDecimal(textBox5.Text);
                save.branchID = Convert.ToInt32(textBox6.Text);
                coon.Personels.Add(save);
                coon.SaveChanges();
                MessageBox.Show("Başarıyla Kayıt Oldunuz");
                PersonelLogin git = new PersonelLogin();
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
