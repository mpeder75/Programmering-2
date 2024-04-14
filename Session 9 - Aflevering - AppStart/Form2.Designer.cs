namespace Session_9___Aflevering___AppStart
{
    partial class Form2
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
            dgvJsonFile = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJsonFile).BeginInit();
            SuspendLayout();
            // 
            // dgvJsonFile
            // 
            dgvJsonFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvJsonFile.BackgroundColor = Color.FromArgb(153, 204, 255);
            dgvJsonFile.BorderStyle = BorderStyle.None;
            dgvJsonFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJsonFile.GridColor = Color.White;
            dgvJsonFile.Location = new Point(12, 42);
            dgvJsonFile.Name = "dgvJsonFile";
            dgvJsonFile.RowTemplate.Height = 25;
            dgvJsonFile.Size = new Size(776, 396);
            dgvJsonFile.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 204, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvJsonFile);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvJsonFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJsonFile;
    }
}