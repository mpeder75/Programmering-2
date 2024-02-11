namespace Session_1___Models_video_4___WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContact = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            SuspendLayout();
            // 
            // dgvContact
            // 
            dgvContact.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContact.BackgroundColor = SystemColors.ControlLight;
            dgvContact.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Location = new Point(32, 75);
            dgvContact.Name = "dgvContact";
            dgvContact.RowTemplate.Height = 25;
            dgvContact.Size = new Size(879, 251);
            dgvContact.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 450);
            Controls.Add(dgvContact);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContact;
    }
}
