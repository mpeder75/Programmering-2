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
    public partial class OverviewPage : Form
    {
        // reference til ContactBL
        ContactBL bl;
        public OverviewPage()
        {
            InitializeComponent();
            bl = new ContactBL();                   // ContactBL initializes
            VisibleChanged += OnVisibleChanged;     // Opret VisibilityChanged     
        }

        private void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (Visible)
            {
                dgvContact.DataSource = bl.GetAll();
            }
        }

        // når knap trykkes, vises en ny form
        private void btnCreateContact_Click(object sender, EventArgs e)
        {
            // 1. instans af CreateContactPage form, så den kan bruges
            CreateContactPage cp = new CreateContactPage(this);

            // 2. når knap trykkes gemmes nuværendne "Overview" page
            this.Hide();

            // 3. CreateContactPage Form vises
            cp.Show();
        }

        // Når der dobbeltclikkes i en celle i datagrridview
        // så kommer en tekstboks med hviklet id det har
        private void CellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridView dgv = (DataGridView)sender;

            DataGridViewRow temp = dgv.Rows[rowIndex];

            int id = (int)temp.Cells[0].Value;

            Contact contact = bl.GetOne(id);

            MessageBox.Show($"FirstName: {contact.FirstName}");

        }
    }
}
