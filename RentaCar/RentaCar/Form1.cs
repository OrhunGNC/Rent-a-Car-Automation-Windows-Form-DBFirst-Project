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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelLogin personel = new PersonelLogin();
            personel.Show();
            this.Hide();
        }

        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerLogin customer = new CustomerLogin();
            customer.Show();
            this.Hide();
        }
    }
}
