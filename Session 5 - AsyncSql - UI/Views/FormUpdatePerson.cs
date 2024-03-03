using Session_5___AsyncSql___BL;
using Session_5___AsyncSql___Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_5___AsyncSql___UI.Views
{
    public partial class FormUpdatePerson : Form
    {
        private readonly PersonBL bl;
        private Person personToUpdate;
        private FormPersonOverview formPersonOverview;
        private readonly FormPersonOverview previous;

        public FormUpdatePerson(Person person)
        {
            InitializeComponent();
            
            bl = new PersonBL();
            personToUpdate = person;
            

            txtUpdateFirstName.Text = person.FirstName;
            txtUpdateLastName.Text = person.LastName;
            txtUpdateAddress.Text = person.Address;
            txtUpdateCity.Text = person.City;
            txtUpdatePostalCode.Text = person.PostalCode.ToString();
            txtUpdateEmail.Text = person.Email;
            txtUpdatePhone.Text = person.Phone.ToString();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to update person?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                personToUpdate.FirstName = txtUpdateFirstName.Text;
                personToUpdate.LastName = txtUpdateLastName.Text;
                personToUpdate.Address = txtUpdateAddress.Text;
                personToUpdate.City = txtUpdateCity.Text;
                personToUpdate.PostalCode = int.Parse(txtUpdatePostalCode.Text);
                personToUpdate.Email = txtUpdateEmail.Text;
                personToUpdate.Phone = int.Parse(txtUpdatePhone.Text);

                bool isUpdated = await bl.UpdateAsync(personToUpdate);

                if (isUpdated)
                {
                    MessageBox.Show("Person updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update person. Please try again.");
                }
            }
        }        
    }
}
