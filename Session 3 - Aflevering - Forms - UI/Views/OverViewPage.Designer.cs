namespace Session_3___Aflevering___Forms___UI.Views
{
    partial class OverViewPage
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvPerson = new DataGridView();
            btnCreatePerson = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // dgvPerson
            // 
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPerson.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPerson.Location = new Point(12, 12);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowTemplate.Height = 25;
            dgvPerson.Size = new Size(337, 257);
            dgvPerson.TabIndex = 0;
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.Location = new Point(438, 41);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(168, 54);
            btnCreatePerson.TabIndex = 1;
            btnCreatePerson.Text = "Create Person";
            btnCreatePerson.UseVisualStyleBackColor = true;
            btnCreatePerson.Click += btnCreatePersonClick;
            // 
            // OverViewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreatePerson);
            Controls.Add(dgvPerson);
            Name = "OverViewPage";
            Text = "OverViewPage";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPerson;
        private Button btnCreatePerson;
    }
}