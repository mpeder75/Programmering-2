using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_9___AfleveringV2
{
    public partial class DetailsMovie : Form
    {
        string Title;       
        string Posterpath;
        string Backdroppath;
        DateTime ReleaseDate;
        string Overview;

        public DetailsMovie(string title, string posterpath, string backdroppath, DateTime releasedate, string overview)
        {
            InitializeComponent();
            this.Title = title;
            this.Posterpath = posterpath;
            this.Backdroppath = backdroppath;
            this.ReleaseDate = releasedate;
            this.Overview = overview;        

            picFront.SizeMode = PictureBoxSizeMode.AutoSize;

            lblTitle.Text = title;
            lblReleaseDate.Text = releasedate.ToString("MM/dd/yyyy");

            txtOverview.Text = overview;
            txtOverview.Multiline = true;            
            txtOverview.Height = 10* txtOverview.Font.Height;      

            LoadImageFromUrlAsync(posterpath, picFront);
        }

        private async Task LoadImageFromUrlAsync(string imageUrl, PictureBox pictureBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(imageUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            var image = new Bitmap(stream);
                            pictureBox.Image = image;
                        }
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
