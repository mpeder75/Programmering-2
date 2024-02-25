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
    public partial class UpdatePersonPage : Form
    {

        Person personToUpdate;
        Form previous;
        PersonBL bl;

        public Person SelectedPerson { get; }

        public UpdatePersonPage(Person selectedPerson, Form previous)
        {
            InitializeComponent();
            personToUpdate = selectedPerson;
            bl = new PersonBL();
            this.previous = previous;
            InitializeForm();
        }       

        private void InitializeForm()
        {
            txtUpdateFirstName.Text = personToUpdate.FirstName;
            txtUpdateLastName.Text = personToUpdate.LastName;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // UpdateAsync the Person object with new values
            personToUpdate.FirstName = txtUpdateFirstName.Text;
            personToUpdate.LastName = txtUpdateLastName.Text;

            // Call the UpdateAsync method in BusinessLogic layer to update the Person
            bl.UpdateAsync(personToUpdate);

            // Close the form
            this.Close();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            previous.Show();
            base.OnClosing(e);
        }

       
    }
}
