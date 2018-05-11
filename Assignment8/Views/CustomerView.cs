using Assignment8.Controller;
using Assignment8.Models;
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
    public partial class CustomerView : Form
    {
        ICustomerController customerController;
        IFlightController flightController;
        public CustomerView()
        {
            customerController = new CustomerController();
            flightController = new FlightController();
            InitializeComponent();
            UpdateCustomerGrid();
            UpdateFlightGrid();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int flightId = int.Parse(cbFlightId.Text);
                Customer customer = new Customer(name, flightId);
                customerController.RegisterCustomer(customer);
                UpdateCustomerGrid();
                lblMessageCustomer.Text = "New Customer Added";
            }catch(Exception ex)
            {
                lblMessageCustomer.Text = ex.Message;
            }
            


        }

        private void UpdateCustomerGrid()
        {
            DataSet customers = customerController.ShowAllCustomers();
            dgCustomer.DataSource = customers.Tables[0];
        }

        private void btnAddNewFlight_Click(object sender, EventArgs e)
        {
            try
            {
                string airline = txtAirline.Text;
                string origin = txtOrogin.Text;
                string destination = txtDestination.Text;
                DateTime date = DateTime.Parse(txtDate.Text);

                Flight flight = new Flight(airline, origin, destination, date);
                flightController.RegisterFlight(flight);
                UpdateFlightGrid();
                lblMessageFlight.Text = "New Flight Added";
            }catch(Exception ex)
            {
                lblMessageFlight.Text = ex.Message;
            }
           
        }

        private void UpdateFlightGrid()
        {
            DataSet flights = flightController.ShowAllFlights();
            dgFlights.DataSource = flights.Tables[0];
            UpdateCompboBoxFlightId();

        }
        private void UpdateCompboBoxFlightId()
        {
            DataSet flights = flightController.ShowAllFlights();
            List<string> flightId = new List<string>();
            cbFlightId.Items.Clear();
            for (int i = 0; i < flights.Tables[0].Rows.Count; i++)
            {
                cbFlightId.Items.Add(flights.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFindCustomer.Text);
            DataSet flights = customerController.SearchCustomer(id);
            dgCustomer.DataSource = flights.Tables[0];
            txtName.Text = flights.Tables[0].Rows[0][0].ToString();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDeleteCustomer.Text);
            customerController.DeleteCustomer(id);
            UpdateCustomerGrid();
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFlightToDelete.Text);
            flightController.DeleteFlight(id);
            UpdateFlightGrid();
        }

        private void btnFlightSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFlightSearch.Text);
            DataSet flights = flightController.SearchFlight(id);
            dgFlights.DataSource = flights.Tables[0];
        }

        private void btnShowAllFlight_Click(object sender, EventArgs e)
        {
            UpdateFlightGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCustomerGrid();
        }
    }
}
