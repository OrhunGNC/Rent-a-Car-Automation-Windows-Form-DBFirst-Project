﻿using System;
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
    public partial class PersonelLogin : Form
    {
        public PersonelLogin()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        public bool PLogin(string namesurname, string phone)
        {
            var query = from user in coon.Personels where user.personelNameSurname == namesurname && user.personelPhone == phone select user;
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
            if (PLogin(textBox1.Text, textBox2.Text))
            {
                PersonelInterface personelint = new PersonelInterface();
                personelint.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Bilgileri!");
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
            PersonelSignup register = new PersonelSignup();
            register.Show();
            this.Hide();
        }
    }
}
