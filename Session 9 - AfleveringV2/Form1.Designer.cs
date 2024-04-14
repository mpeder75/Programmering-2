namespace Session_9___AfleveringV2
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
            dgvJsonFile = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJsonFile).BeginInit();
            SuspendLayout();
            // 
            // dgvJsonFile
            // 
            dgvJsonFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJsonFile.Location = new Point(24, 33);
            dgvJsonFile.Name = "dgvJsonFile";
            dgvJsonFile.RowTemplate.Height = 25;
            dgvJsonFile.Size = new Size(1045, 750);
            dgvJsonFile.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 809);
            Controls.Add(dgvJsonFile);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvJsonFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJsonFile;
    }
}
