using Session_1___Models_video_4___BusinessLogic;

namespace Session_1___Models_video_4___WinForm
{
    public partial class Form1 : Form
    {
        // ref til BuisnessLogic
        ContactBL bl;
        public Form1()
        {
           InitializeComponent();
            bl = new ContactBL();  // reference til BusinessLogic istancieres

            dgvContact.DataSource = bl.GetAll();  // DataGridView får sin datasource fra CRUD GetAll() 
        }
    }
}

