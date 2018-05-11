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
            txtCustomerId.Hide();
            txtFlightId.Hide();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            ResetMessages();
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
            ResetMessages();
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
            ResetMessages();
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
            ResetMessages();
            int id = int.Parse(txtFindCustomer.Text);
            DataSet flights = customerController.SearchCustomer(id);
            dgCustomer.DataSource = flights.Tables[0];
            try
            {
                txtName.Text = flights.Tables[0].Rows[0][0].ToString();
                txtCustomerId.Text = flights.Tables[0].Rows[0][5].ToString();

            }
            catch(Exception ex)
            {
                lblMessageCustomer.Text = ex.Message;
            }


        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            ResetMessages();
            try
            {
                int id = int.Parse(txtDeleteCustomer.Text);
                customerController.DeleteCustomer(id);
                UpdateCustomerGrid();
            }
            catch(Exception ex)
            {
                lblMessageCustomer.Text = ex.Message;
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            ResetMessages();
            try
            {
                int id = int.Parse(txtFlightToDelete.Text);
                flightController.DeleteFlight(id);
                UpdateFlightGrid();
            }
           catch(Exception ex)
            {
                lblMessageFlight.Text = ex.Message;
            }
        }

        private void btnFlightSearch_Click(object sender, EventArgs e)
        {
            ResetMessages();
            try
            {
                int id = int.Parse(txtFlightSearch.Text);
                DataSet flights = flightController.SearchFlight(id);
                dgFlights.DataSource = flights.Tables[0];
                txtFlightId.Text = flights.Tables[0].Rows[0][6].ToString();
                txtAirline.Text = flights.Tables[0].Rows[0][2].ToString();
                txtOrogin.Text = flights.Tables[0].Rows[0][3].ToString();
                txtDestination.Text = flights.Tables[0].Rows[0][4].ToString();
                txtDate.Text = flights.Tables[0].Rows[0][5].ToString();

            }
            catch(Exception ex)
            {
                lblMessageFlight.Text = ex.Message;
            }

            
        }

        private void btnShowAllFlight_Click(object sender, EventArgs e)
        {
            UpdateFlightGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCustomerGrid();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            ResetMessages();
            if (txtFindCustomer.Text == "")
            {
                MessageBox.Show("Please find the Customer first.");
            }
            try
            {
                int id = int.Parse(txtCustomerId.Text);
                string name = txtName.Text;
                EditCustomer(id, name, int.Parse(cbFlightId.Text));
                UpdateCustomerGrid();
            }
            catch (Exception ex)
            {
                lblMessageCustomer.Text = ex.Message;
            }
        }

        private void EditCustomer(int id, string name, int flightId)
        {
            ResetMessages();
            try
            {
                Customer customer = new Customer(id, name, flightId);
                customerController.EditCustomer(customer);
            }
            catch(Exception ex)
            {
                lblMessageCustomer.Text = ex.Message;
            }
           
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            ResetMessages();
            try
            {
                int id = int.Parse(txtFlightId.Text);
                Flight flight = new Flight(id, txtAirline.Text, txtOrogin.Text, txtDestination.Text, DateTime.Parse(txtDate.Text));
                flightController.EditFlight(flight);
                UpdateFlightGrid();
            }
            catch(Exception ex)
            {
                lblMessageFlight.Text = ex.Message;
            }
           
        }
        private void ResetMessages()
        {
            lblMessageCustomer.Text = "";
            lblMessageFlight.Text = "";
        }
    }
}
