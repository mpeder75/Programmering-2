using Session_3___Aflevering___Forms___BL;
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
    public partial class OverViewPage : Form
    {
        PersonBL bl;
        public OverViewPage()
        {
            InitializeComponent();
            bl = new PersonBL();
            VisibleChanged += OnVisibleChanged;
        }

        private void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (Visible)
            {
                dgvPerson.DataSource = bl.GetAll();
            }
        }

        private void btnCreatePersonClick(object sender, EventArgs e)
        {
            CreatePerson cp = new CreatePerson(this);

            this.Hide();

            cp.Show();
        }
    }
}
