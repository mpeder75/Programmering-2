using Session_5___AsyncSql___BL;
using Session_5___AsyncSql___Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Session_5___AsyncSql___UI.Views
{
    public partial class FormPerson : Form
    {
        private readonly Form previous;  // ref til forgåendne side; 
        PersonBL bl;                    // ref til businessLogic
          

        public FormPerson(Form previous)
        {
            InitializeComponent();
            this.previous = previous;
            bl = new PersonBL();           

            txtFirstName.TextChanged += TxtFirstNameTextChanged;
            txtLastName.TextChanged += TxtLastNameTextChanged;
            txtAddress.TextChanged += TxtAddressTextChanged;
            txtCity.TextChanged += TxtCityTextChanged;
            txtPostalCode.TextChanged += TxtPostalCodeTextChanged;
            txtEmail.TextChanged += TxtEmailTextChanged;
            txtPhone.TextChanged += TxtPhoneTextChanged;
        }        

        /*
        public void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtAddress.Text = txtCity.Text = txtPostalCode.Text = string.Empty;

            if (txtEmail != null)
            {
                txtEmail.Text = string.Empty;
            }

            if (txtPhone != null)
            {
                txtPhone.Text = string.Empty;
            }
        }*/

        private void TxtFirstNameTextChanged(object? sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim().Length > 0 && txtFirstName.Text.Trim().Length < 51)
            {
                txtFirstName.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Firstname too short or too long (1-50)");
                txtFirstName.ForeColor = Color.Red;
            }
            ModelValidation();
        }

        private void TxtLastNameTextChanged(object? sender, EventArgs e)
        {
            if (txtLastName.Text.Trim().Length > 0 && txtLastName.Text.Trim().Length < 51)
            {
                txtLastName.ForeColor = Color.Green;

            }
            else
            {
                MessageBox.Show("Lastname too short or too long (1-50)");
                txtLastName.ForeColor = Color.Red;
            }
            ModelValidation();
        }

        private void TxtAddressTextChanged(object? sender, EventArgs e)
        {
            if (txtAddress.Text.Trim().Length > 0 && txtAddress.Text.Trim().Length < 100)
            {
                txtAddress.ForeColor = Color.Green;

            }
            else
            {
                MessageBox.Show(text: "Address too short or too long (1-50)");
                txtAddress.ForeColor = Color.Red;
            }
            ModelValidation();
        }

        private void TxtCityTextChanged(object? sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length > 0 && txtCity.Text.Trim().Length < 51)
            {
                txtCity.ForeColor = Color.Green;

            }
            else
            {
                MessageBox.Show("City too short or too long (1-50)");
                txtCity.ForeColor = Color.Red;
            }
            ModelValidation();
        }

        private void TxtPostalCodeTextChanged(object? sender, EventArgs e)
        {
            int postalCode;
            if (!int.TryParse(txtPostalCode.Text.Trim(), out postalCode))
            {
                MessageBox.Show("Postal code can only be an integer");
                txtPostalCode.ForeColor = Color.Red;
            }

            txtPostalCode.ForeColor = Color.Green;
            ModelValidation();
        }

        private void TxtEmailTextChanged(object? sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Green;

            ModelValidation();
        }


        private void TxtPhoneTextChanged(object? sender, EventArgs e)
        {
            txtPhone.ForeColor = Color.Green;

            ModelValidation();
        }


        private bool ModelValidation()
        {
            bool isValidFirstName = txtFirstName.ForeColor == Color.Green;
            bool isValidLastName = txtLastName.ForeColor == Color.Green;
            bool isValidAddress = txtAddress.ForeColor == Color.Green;
            bool isValidCity = txtCity.ForeColor == Color.Green;
            bool isValidPostalCode = txtPostalCode.ForeColor == Color.Green;

            bool isValid = isValidFirstName &&
                           isValidLastName &&
                           isValidAddress &&
                           isValidCity &&
                           isValidPostalCode;

            btnSavePerson.Enabled = isValid;
            return isValid;
        }

        private async void btnSavePersonClick(object sender, EventArgs e)
        {
            if (ModelValidation())
            {
                Person newPerson = new Person()
                {
                    Id = bl.FindNextId(),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    PostalCode = int.Parse(txtPostalCode.Text),
                    Email = txtEmail.Text,
                    Phone = int.Parse(txtPhone.Text)
                };

                bool isCreated = await bl.CreateAsync(newPerson);

                if (isCreated)
                {
                    MessageBox.Show("Person created");
                    previous.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to create person");
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            previous.Show();
            base.OnClosing(e);
        }
    }
}
