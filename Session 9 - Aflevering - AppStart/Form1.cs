using Newtonsoft.Json;
using Session_9___Aflevering___AppStart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Session_9___Aflevering___AppStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        // Hugget fra: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-8.0&viewFallbackFrom=net-6.0&source=recommendations
        private void btnSearchJsonLocation_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

           using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // bruger peger på fillokation, som gemmes i variablen filePath
                    filePath = openFileDialog.FileName;
                    // json data læses fra filePath
                    string jsonContent = File.ReadAllText(filePath);
                    //
                    DataJson.Rootobject rootObject = JsonConvert.DeserializeObject<DataJson.Rootobject>(jsonContent, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    // nu åbnes Form2 og der sendes filePath med
                    var form2 = new Form2(rootObject);
                    form2.Show();
                }
            }
        }
    }
}
