using Session_3___Aflevering___Forms___BL;
using Session_3___Aflevering___Forms___Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_3___Aflevering___Forms___UI.Views
{
    public partial class CreatePerson : Form
    {
        private readonly Form previous;
        PersonBL bl;

        public CreatePerson(Form previous)
        {
            InitializeComponent();
            btnCreateNewPerson.Enabled = false;
            this.previous = previous;
            bl = new PersonBL();

            txtFirstName.TextChanged += TxtFirstNameTextChanged;
            txtLastName.TextChanged += TxtLastNameTextChanged;
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

        private void ModelValidation()
        {
            if (txtLastName.TextLength > 1 && txtLastName.TextLength < 51)
            {
                if (txtLastName.TextLength > 1 && txtLastName.TextLength < 51)
                {
                   btnCreateNewPerson.Enabled = true;
                }
                else
                {
                    btnCreateNewPerson.Enabled = false;
                }
            }
            else
            {
                btnCreateNewPerson.Enabled= false;
            }
        }

        private void btnCreatePersonClick(object sender, EventArgs e)
        {
            btnCreateNewPerson.Enabled = false;

            int nextId = bl.FindNextId();

            Person newPerson = new Person() { Id = nextId, FirstName = txtFirstName.Text, LastName = txtLastName.Text };

            bool isCreated = bl.Create(newPerson);

            if (isCreated)
            {
                MessageBox.Show("Person added to List");
                previous.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Person NOT added");
            }
            btnCreateNewPerson.Enabled = true;
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            previous.Show();
            base.OnClosing(e);
        }
    }
}
