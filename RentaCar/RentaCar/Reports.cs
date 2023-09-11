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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var query = from branch in coon.Branches
                        join vehicle in coon.Vehicles
                        on branch.branchID equals vehicle.branchID
                        select new
                        {
                            branch.branchName,
                            branch.branchSalary,
                            branch.branchEmployeeCount,
                            vehicle.vehiclePrice,
                            vehicle.vehicleModel,
                            vehicle.vehicleBrand,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var query = from personel in coon.Personels
                        join branch in coon.Branches
                        on personel.branchID equals branch.branchID
                        select new
                        {
                            personel.personelNameSurname,
                            personel.personelPhone,
                            personel.personelTitle,
                            branch.branchName,
                            branch.branchID,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var query = from customer in coon.Customers
                        join vehicle in coon.Vehicles
                        on customer.customerID equals vehicle.customerID
                        select new
                        {
                            customer.customerNameSurname,
                            customer.customerPhone,
                            customer.customerAge,
                            customer.customerBudget,
                            vehicle.vehiclePrice,
                            vehicle.vehicleModel,
                            vehicle.vehicleBrand,
                            vehicle.vehicleYear,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var query = from customer in coon.Customers
                        join vehicle in coon.Vehicles
                        on customer.customerID equals vehicle.customerID
                        from branch in coon.Branches
                        join vehicle2 in coon.Vehicles
                        on branch.branchID equals vehicle2.branchID
                        select  new
                        {
                            customer.customerNameSurname,
                            customer.customerBudget,
                            vehicle.vehiclePrice,
                            vehicle.vehiclePackage,
                            vehicle.vehicleBrand,
                            branch.branchName,
                            branch.carStock,
                            branch.branchSalary,
                        };
            dataGridView1.DataSource= query.Distinct().ToList();
                        
                        
        }
    }
}
