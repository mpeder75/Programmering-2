using Session_4___BL;
using Session_4___Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_4___UI.Views
{
    public partial class CreatePersonPage : Form
    {
        private readonly Form previous;
        PersonBL bl;

        public CreatePersonPage(Form previous)
        {
            InitializeComponent();      
            this.previous = previous;
            bl = new PersonBL();

            txtFirstName.TextChanged += TxtFirstNameTextChanged;
            txtLastName.TextChanged += TxtLastNameTextChanged;
        }

        private void TxtLastNameTextChanged(object? sender, EventArgs e)
        {
            if (txtLastName.TextLength > 1 && txtLastName.TextLength < 51)
            {
                txtLastName.ForeColor = Color.Green;
                ModelValidation();
            }
            else
            {
                txtLastName.ForeColor = Color.Red;
            }
        }

        private void TxtFirstNameTextChanged(object? sender, EventArgs e)
        {
            if (txtFirstName.TextLength > 1 && txtFirstName.TextLength < 51)
            {
                txtFirstName.ForeColor = Color.Green;
                ModelValidation();
            }
            else
            {
                txtFirstName.ForeColor = Color.Red;
            }
        }

        void ModelValidation()
        {
            if (txtFirstName.TextLength > 1 && txtFirstName.TextLength < 51)
            {
                if (txtLastName.TextLength > 1 && txtLastName.TextLength < 51)
                {
                    btnCreatePerson.Enabled = true;
                }
                else
                {
                    btnCreatePerson.Enabled = false;  // Hvis ikke validereing overholdes er button disabled
                }
            }
            else
            {
                btnCreatePerson.Enabled = false;
            }
        }       

        private  async void btnCreatePerson_Click(object sender, EventArgs e)
        {
            btnCreatePerson.Enabled = false;

            Person newPerson = new Person() { FirstName = txtFirstName.Text, LastName = txtLastName.Text };

            bool isCreated = await bl.CreateAsync(newPerson);
            

            if (isCreated) 
            {
                MessageBox.Show("New Person added");              
                previous.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Person NOT created");
            }
            btnCreatePerson.Enabled = true;
        }

      

        protected override void OnClosing(CancelEventArgs e)
        {
            previous.Show();
            base.OnClosing(e);
        }
    }
}
