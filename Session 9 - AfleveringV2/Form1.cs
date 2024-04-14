using Newtonsoft.Json;
using Session_9___AfleveringV2.Models;
using System.Reflection;
using System.Windows.Forms;
using static Session_9___AfleveringV2.Models.DataJson;

namespace Session_9___AfleveringV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadJsonData();
            dgvJsonFile.CellDoubleClick += DgvJsonFileCellDoubleClick;
        }

        private void DgvJsonFileCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridView dgvJsonFile = sender as DataGridView;

            string title = dgvJsonFile.Rows[row].Cells["Title"].Value.ToString();
            string posterPath = dgvJsonFile.Rows[row].Cells["PosterPath"].Value.ToString();
            string backDropPath = dgvJsonFile.Rows[row].Cells["BackdropPath"].Value.ToString();
            string overView = dgvJsonFile.Rows[row].Cells["Overview"].Value.ToString();
            
            DateTime releaseDate;
            if (DateTime.TryParse(dgvJsonFile.Rows[row].Cells["ReleaseDate"].Value.ToString(), out releaseDate))
            {
                NavToDetails(title, posterPath, backDropPath, releaseDate, overView);
            }
            else
            {
                // Handle invalid date format (e.g., log an error, show a message, etc.)
                MessageBox.Show("Invalid release date format.");
            }
        }

        private void NavToDetails(string title, string posterpath, string backdroppath, DateTime releasedate, string overview)
        {
            this.Hide();
            DetailsMovie detailsMovieForm = new DetailsMovie(title, posterpath, backdroppath, releasedate, overview);
            detailsMovieForm.Show();
        }

        private void LoadJsonData()
        {
            try
            {
                string jsonFilePath = "c:\\test\\TopratedRelations.json"; 
                string jsonContent = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON into a list of Movie objects (assuming you have the Movie class)
                List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(jsonContent);

                // Bind DataGridView til list
                dgvJsonFile.DataSource = movies;

                // data der ikke skal vises i datagridView
                dgvJsonFile.Columns["Id"].Visible = false;
                dgvJsonFile.Columns["Adult"].Visible = false;
                dgvJsonFile.Columns["PosterPath"].Visible = false;
                dgvJsonFile.Columns["Video"].Visible = false; 
                dgvJsonFile.Columns["VoteCount"].Visible = false;
                dgvJsonFile.Columns["MovieId"].Visible = false;
                dgvJsonFile.Columns["BackDropPath"].Visible = false;
                dgvJsonFile.Columns["Overview"].Visible = false;
                dgvJsonFile.Columns["Popularity"].Visible = false;
                dgvJsonFile.Columns["OriginalLanguage"].Visible = false;
                

                // looper columns igennem og autosizer hver column så de udfyldes
                foreach (DataGridViewColumn column in dgvJsonFile.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading JSON data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
