using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Session_9___Aflevering___AppStart.Models;
using static Session_9___Aflevering___AppStart.Models.DataJson;

namespace Session_9___Aflevering___AppStart
{
    public partial class Form2 : Form
    {
        private readonly DataJson.Rootobject _rootObject;

        public Form2(DataJson.Rootobject rootObject)
        {
            InitializeComponent();
            _rootObject = rootObject;
            VisibleChanged += Form2_VisibleChanged;
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                PopulateDataGridView();
            }
        }

        private void PopulateDataGridView()
        {
            dgvJsonFile.Rows.Clear();
            dgvJsonFile.Columns.Clear();

            dgvJsonFile.Columns.Add("Title", "Title");
            dgvJsonFile.Columns.Add("ReleaseDate", "Release date");

            foreach (DataJson.Class1 movie in _rootObject.Property1)
            {
                dgvJsonFile.Rows.Add(movie.Title, movie.ReleaseDate);
            }
        }


    }
}
