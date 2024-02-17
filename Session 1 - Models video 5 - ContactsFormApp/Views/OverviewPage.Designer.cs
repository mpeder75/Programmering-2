namespace Session_1___Models_video_5___ContactsFormApp.Views
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
            dgvContact = new DataGridView();
            btnCreateContact = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            SuspendLayout();
            // 
            // dgvContact
            // 
            dgvContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Location = new Point(25, 55);
            dgvContact.Name = "dgvContact";
            dgvContact.RowTemplate.Height = 25;
            dgvContact.Size = new Size(547, 350);
            dgvContact.TabIndex = 0;
            dgvContact.CellDoubleClick += CellDoubleClicked;
            // 
            // btnCreateContact
            // 
            btnCreateContact.Location = new Point(588, 55);
            btnCreateContact.Name = "btnCreateContact";
            btnCreateContact.Size = new Size(165, 64);
            btnCreateContact.TabIndex = 1;
            btnCreateContact.Text = "Create contact";
            btnCreateContact.UseVisualStyleBackColor = true;
            btnCreateContact.Click += btnCreateContact_Click;
            // 
            // OverviewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateContact);
            Controls.Add(dgvContact);
            Name = "OverviewPage";
            Text = "OverviewPage";
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContact;
        private Button btnCreateContact;
    }
}