using Session_4___BL;
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
    public partial class OverviewPage : Form
    {
        PersonBL bl;

        public OverviewPage()
        {
            InitializeComponent();
            bl = new PersonBL();

            VisibleChanged += OverviewPage_VisibleChanged;          
        }

        private void OverviewPage_VisibleChanged(object? sender, EventArgs e)
        {
            dgvPerson.DataSource = bl.GetAll();
        }
    }
}
