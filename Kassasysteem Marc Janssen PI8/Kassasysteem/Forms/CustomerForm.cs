using kassa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kassa.Forms
{
    public partial class CustomerForm : Form
    {
        private int rowIndex = -1;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void toggleModus()
        {
            createCustomerButton.Visible = !createCustomerButton.Visible;
            editCustomerButton.Visible = !editCustomerButton.Visible;
            cancelCustomerButton.Visible = !cancelCustomerButton.Visible;
            deleteCustomerButton.Visible = !deleteCustomerButton.Visible;
        }

        private void clearInput()
        {
            firstNameInput.Text = "";
            lastNameInput.Text = "";
            birthDatePicker.Value = DateTime.Now;
            emailAddressInput.Text = "";
        }

        private void handleCustomer(Customer customer)
        {
            // Als er geen customer door gegeven is weet je dat het om een delete draait ivm het object
            // Indien er dan een rij positie gezet is boven of gelijk aan 0 weet je dat deze ge-edit wordt en anders is het een create.
            if (customer != null)
            {
                if (this.rowIndex >= 0)
                {
                    clearInput();
                    customerDataGridView.Rows.RemoveAt(rowIndex);
                    customerDataGridView.Rows.Insert(rowIndex, customer.FirstName, customer.LastName, customer.BirthDate.ToShortDateString(), customer.EmailAddress, "Edit");
                    MessageBox.Show("Customer has been edited!");
                }
                else
                {
                    clearInput();
                    customerDataGridView.Rows.Add(customer.FirstName, customer.LastName, customer.BirthDate.ToShortDateString(), customer.EmailAddress, "Edit");
                    MessageBox.Show("Customer has been created!");
                }
            } else
            {
                if (this.rowIndex >= 0)
                {
                    clearInput();
                    customerDataGridView.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Customer has been removed!");
                }
            }
         
            this.rowIndex = -1;
        }

        private Customer handleInput()
        {
            // Haalt de informatie uit de textboxes en creeert de customer class.
            string firstName = firstNameInput.Text;
            string lastName = lastNameInput.Text;
            DateTime birthDate = birthDatePicker.Value.Date;
            string emailAddress = emailAddressInput.Text;

            if (firstName != "" && lastName != "" && emailAddress != "")
            {
                Customer customer = new Customer();

                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.BirthDate = birthDate;
                customer.EmailAddress = emailAddress;

                return customer;
            } else
            {
                MessageBox.Show("Not all values have been entered!");
                return null;
            }
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerDataGridView.Columns[e.ColumnIndex].Name.Equals("Actions"))
            {
                if (editCustomerButton.Visible != true)
                {
                    toggleModus();
                }

                rowIndex = e.RowIndex;

                string firstName = customerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                firstNameInput.Text = firstName;

                string lastName = customerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                lastNameInput.Text = lastName;

                DateTime dateTime = DateTime.Parse(customerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                birthDatePicker.Value = dateTime;

                string emailAddress = customerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                emailAddressInput.Text = emailAddress;
            }
        }

        
        private void cancelCustomerButton_Click(object sender, EventArgs e)
        {
            clearInput();
            toggleModus();
        }

        private void customerCreateButton_Click(object sender, EventArgs e)
        {
            Customer customer = handleInput();
            handleCustomer(customer);
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = handleInput();
            handleCustomer(customer);
            toggleModus();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            handleCustomer(null);
            toggleModus();
        }
    }
}
