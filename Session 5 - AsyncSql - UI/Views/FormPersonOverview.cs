using Session_5___AsyncSql___BL;
using Session_5___AsyncSql___Models;


namespace Session_5___AsyncSql___UI.Views
{
    public partial class FormPersonOverview : Form
    {
        PersonBL bl;
        Person person;
        private string searchTerm = string.Empty;
        private FormPerson form;
        private FormUpdatePerson formUpdatePerson;

        public FormPersonOverview()
        {
            InitializeComponent();
            bl = new PersonBL();
            person = new Person();
            form = new FormPerson(this);            
            VisibleChanged += OnVisibleChanged;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }


        private async void OnVisibleChanged(object? sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                dgvPersons.DataSource = await bl.GetAllAsync();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            searchTerm = txtSearch.Text.Trim();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
            }
        }

        private async void PerformSearch()
        {
            try
            {
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    dgvPersons.DataSource = await bl.GetOneAsync(searchTerm);
                }
                else
                {
                    dgvPersons.DataSource = await bl.GetAllAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            //form.Clear();
            form.ShowDialog();
        }
        /*
                private async void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        if (e.ColumnIndex == 0)
                        {
                            // UpdateAsync
                            int id;
                            if (int.TryParse(GetValueFromCell(e.RowIndex, 2), out id))
                            {
                                form.Id = id; // Set the Id property
                                form.firstname = GetValueFromCell(e.RowIndex, 3);
                                form.lastname = GetValueFromCell(e.RowIndex, 4);
                                form.address = GetValueFromCell(e.RowIndex, 5);
                                form.city = GetValueFromCell(e.RowIndex, 6);
                                form.postalcode = GetValueFromCell(e.RowIndex, 7);
                                form.email = GetValueFromCell(e.RowIndex, 8);
                                form.phone = GetValueFromCell(e.RowIndex, 9);

                                form.Update();
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (e.ColumnIndex == 1)
                        {
                            // DeleteAsync
                            if (MessageBox.Show("Are you sure you want to delete person?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                int id;
                                if (int.TryParse(GetValueFromCell(e.RowIndex, 2), out id))
                                {
                                    await bl.DeleteAsync(id);
                                    MessageBox.Show("Deletion successful");
                                    await RefreshDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }*/


        private async void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    // Get the ID from the data grid view
                    if (int.TryParse(GetValueFromCell(e.RowIndex, 2), out int id))
                    {
                        // Retrieve the person's data based on the ID
                        Person person = await bl.GetOneAsync(id);

                        if (person != null)
                        {
                            // Create an instance of FormUpdatePerson and pass the person's data
                            FormUpdatePerson formUpdatePerson = new FormUpdatePerson(person);

                            // Show FormUpdatePerson as a dialog
                            formUpdatePerson.ShowDialog();

                            // Refresh the data grid view after closing FormUpdatePerson
                            await RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    // DeleteAsync
                    if (MessageBox.Show("Are you sure you want to delete person?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int id;
                        if (int.TryParse(GetValueFromCell(e.RowIndex, 2), out id))
                        {
                            await bl.DeleteAsync(id);
                            MessageBox.Show("Deletion successful");
                            await RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private string GetValueFromCell(int rowIndex, int columnIndex)
        {
            var cellValue = dgvPersons.Rows[rowIndex].Cells[columnIndex].Value;
            return cellValue != null ? cellValue.ToString() : "";
        }

        public async Task RefreshDataGridView()
        {
            dgvPersons.DataSource = await bl.GetAllAsync();
        }
    }
}

