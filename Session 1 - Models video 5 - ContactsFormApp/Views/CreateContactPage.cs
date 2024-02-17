using Session_1___Models_video_5___BL;
using Session_1___Models_video_5___Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_1___Models_video_5___ContactsFormApp.Views
{
    public partial class CreateContactPage : Form
    {
        private readonly Form previous;
        ContactBL bl;

        // Argument "Form previous" gør at man kan gå tilbage til forrige form
        public CreateContactPage(Form previous)
        {
            InitializeComponent();
            btnCreateNewContact.Enabled = false;  // gør at CreatenewContact btn ikke er aktiv når form åbnes
            this.previous = previous;
            bl = new ContactBL();

            // vi subscriber at når der skrives i tekstfeltet Firstname - valideres det i "TxtFirstNameTextChanged"
            txtFirstName.TextChanged += TxtFirstNameTextChanged;
            // vi subscriber at når der skrives i tekstfeltet Lastname - valideres det i "TxtLastNameTextChanged"
            txtLastName.TextChanged += TxtLastNameTextChanged;
        }

        // event, når der skrives i tekstfeltet Firstname validers det der indtastes
        private void TxtFirstNameTextChanged(object? sender, EventArgs e)
        {
            if (txtFirstName.TextLength > 1 && txtFirstName.TextLength < 51)
            {
                txtFirstName.ForeColor = Color.Green;   // Hvis validering overholdes er tekstboks grøn 
                ModelValidation();                      // så kaldes ModelsValidation               
            }
            else
            {
                txtFirstName.ForeColor = Color.Red;      // Hvis den ikke overholder er farve rød  
            }

        }

        // event, når der skrives i tekstfeltet LastName validers det der indtastes
        private void TxtLastNameTextChanged(object? sender, EventArgs e)
        {
            if (txtLastName.TextLength > 1 && txtLastName.TextLength < 51)
            {
                txtLastName.ForeColor = Color.Green;   // Hvis validering overholdes er tekstboks grøn 
                ModelValidation();                     // så kaldes ModelsValidation 
            }
            else
            {
                txtLastName.ForeColor = Color.Red;      // Hvis den ikke overholder er farve rød  
            }
        }

        // Når validering af tekst er overholdt, bliver Create button enablet igen
        void ModelValidation()
        {
            if (txtFirstName.TextLength > 1 && txtFirstName.TextLength < 51)
            {
                if (txtLastName.TextLength > 1 && txtLastName.TextLength < 51)
                {
                    btnCreateNewContact.Enabled = true;
                }
                else
                {
                    btnCreateNewContact.Enabled = false;  // Hvis ikke validereing overholdes er button disabled
                }
            }
            else
            {
                btnCreateNewContact.Enabled = false;
            }
        }



        private void btnCreateNewContact_Click(object sender, EventArgs e)
        {
            btnCreateNewContact.Enabled = false;

            // ny newContact oprettes, med det der er skrevet i tekstfelterne Firstname og Lastname
            Contact newContact = new Contact() { FirstName = txtFirstName.Text, LastName = txtLastName.Text };

            // den oprettede contact sendes til BL.Create()
            bool isCreated = bl.Create(newContact);

            // når Contact er oprettet, får bruger besked og der navigered tilbage til forside
            if (isCreated)
            {

                MessageBox.Show("New Conntact created");
                previous.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contact NOT created");
            }
            btnCreateNewContact.Enabled = true;
        }

        // hvis man clikker på "krydset", vises forrige Form (og denne lukkes) 
        protected override void OnClosing(CancelEventArgs e)
        {
            previous.Show();    // forrige vises
            base.OnClosing(e);  // denn form lukkes
        }
    }
}
