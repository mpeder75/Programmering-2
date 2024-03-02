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
    public partial class FormPersonOverview : Form
    {
        public FormPersonOverview()
        {
            InitializeComponent();

            /*
            HVIS man vil lave styling i code
            panelPerson.BackColor = Color.FromArgb(160, 113, 255);
            btnCreatPerson.BackColor = Color.FromArgb(160, 113, 255);
            */
        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            // instans af side
            FormPerson personForm = new FormPerson();

            personForm.ShowDialog();

            this.Hide();
        }
    }
}
