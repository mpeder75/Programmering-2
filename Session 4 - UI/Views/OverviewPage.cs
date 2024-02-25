using Session_4___BL;
using Session_4___Models;


namespace Session_4___UI.Views
{
    public partial class OverviewPage : Form
    {
        PersonBL bl;       

        public OverviewPage()
        {
            InitializeComponent();
            bl = new PersonBL();
            VisibleChanged += OnVisibleChanged;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvPerson.Columns.Add(deleteButtonColumn);

            // Step 2: Handle CellContentClick event
            dgvPerson.CellContentClick += dgvPerson_CellContentClick;

            dgvPerson.RowHeadersVisible = false;
        }

        private async void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (Visible)
            {
                await RefreshDataGridViewAsync();
            }
        }

        private async Task RefreshDataGridViewAsync()
        {
           List<Person> persons = await bl.GetAllAsync();
            dgvPerson.DataSource = persons;          
        }


        private async void btnCreatePerson_Click(object sender, EventArgs e)
        {
            CreatePersonPage createPersonPage = new CreatePersonPage(this);

            this.Hide();

            createPersonPage.Show();

            await RefreshDataGridViewAsync();
        }


        private async void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPerson.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvPerson.Rows[e.RowIndex];
                DataGridViewCell clickedCell = dgvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell is DataGridViewButtonCell && clickedCell.Value != null && clickedCell.Value.ToString() == "DeleteAsync")
                {
                    // Retrieve the person from the corresponding row
                    Person selectedPerson = (Person)selectedRow.DataBoundItem;

                    // Perform the delete operation
                    bl.DeleteAsync(selectedPerson.Id);

                    // Refresh the DataGridView
                    dgvPerson.DataSource = null;
                    dgvPerson.DataSource = await bl.GetAllAsync();
                }
                else
                {
                    // Retrieve the person from the corresponding row
                    Person selectedPerson = (Person)selectedRow.DataBoundItem;

                    // Handle other cell click actions, such as opening the update form
                    UpdatePersonPage updateForm = new UpdatePersonPage(selectedPerson, this);
                    updateForm.ShowDialog();
                }
            }
        }
    }
}
