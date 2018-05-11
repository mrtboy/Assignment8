using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.airportDataSet.Flight);
            // TODO: This line of code loads data into the 'airportDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.airportDataSet.Customer);

        }
    }
}
