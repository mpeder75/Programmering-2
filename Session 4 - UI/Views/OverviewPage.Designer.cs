namespace Session_4___UI.Views
{
    partial class OverviewPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPerson = new DataGridView();
            btnCreatePerson = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // dgvPerson
            // 
            dgvPerson.AllowUserToOrderColumns = true;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(33, 31);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPerson.RowTemplate.Height = 25;
            dgvPerson.Size = new Size(544, 195);
            dgvPerson.TabIndex = 0;
            dgvPerson.CellContentClick += dgvPerson_CellContentClick;
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.Location = new Point(33, 270);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(111, 47);
            btnCreatePerson.TabIndex = 1;
            btnCreatePerson.Text = "Create Person";
            btnCreatePerson.UseVisualStyleBackColor = true;
            btnCreatePerson.Click += btnCreatePerson_Click;
            // 
            // OverviewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreatePerson);
            Controls.Add(dgvPerson);
            Name = "OverviewPage";
            Text = "StartPage";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPerson;
        private Button btnCreatePerson;
    }
}