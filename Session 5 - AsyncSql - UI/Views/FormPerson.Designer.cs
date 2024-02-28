namespace Session_5___AsyncSql___UI.Views
{
    partial class FormPerson
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            panelPerson = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            dgvPersons = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewButtonColumn();
            Column11 = new DataGridViewButtonColumn();
            btnCreatPerson = new Button();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panelPerson.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPerson
            // 
            panelPerson.BackColor = Color.FromArgb(160, 113, 255);
            panelPerson.Controls.Add(label1);
            panelPerson.Dock = DockStyle.Top;
            panelPerson.Location = new Point(0, 0);
            panelPerson.Name = "panelPerson";
            panelPerson.Size = new Size(967, 142);
            panelPerson.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 55);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Person Info";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvPersons);
            panel1.Controls.Add(btnCreatPerson);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(31, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 363);
            panel1.TabIndex = 0;
            // 
            // dgvPersons
            // 
            dgvPersons.AllowUserToAddRows = false;
            dgvPersons.AllowUserToDeleteRows = false;
            dgvPersons.AllowUserToResizeColumns = false;
            dgvPersons.AllowUserToResizeRows = false;
            dgvPersons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersons.BackgroundColor = Color.White;
            dgvPersons.BorderStyle = BorderStyle.None;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dgvPersons.GridColor = Color.White;
            dgvPersons.Location = new Point(26, 77);
            dgvPersons.MultiSelect = false;
            dgvPersons.Name = "dgvPersons";
            dgvPersons.ReadOnly = true;
            dgvPersons.RowHeadersVisible = false;
            dgvPersons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPersons.RowTemplate.Height = 25;
            dgvPersons.ShowEditingIcon = false;
            dgvPersons.Size = new Size(845, 242);
            dgvPersons.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Id";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fornavn";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Efternavn";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Addresse";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "City";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Postnr";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Telefon";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            Column10.DefaultCellStyle = dataGridViewCellStyle1;
            Column10.FlatStyle = FlatStyle.Flat;
            Column10.HeaderText = "";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Text = "Update";
            Column10.UseColumnTextForButtonValue = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(160, 113, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(160, 113, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Column11.DefaultCellStyle = dataGridViewCellStyle2;
            Column11.FlatStyle = FlatStyle.Flat;
            Column11.HeaderText = "";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Text = "Delete";
            Column11.UseColumnTextForButtonValue = true;
            // 
            // btnCreatPerson
            // 
            btnCreatPerson.BackColor = Color.FromArgb(160, 113, 255);
            btnCreatPerson.FlatAppearance.BorderSize = 0;
            btnCreatPerson.FlatStyle = FlatStyle.Flat;
            btnCreatPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreatPerson.ForeColor = Color.White;
            btnCreatPerson.Location = new Point(26, 22);
            btnCreatPerson.Name = "btnCreatPerson";
            btnCreatPerson.Size = new Size(88, 34);
            btnCreatPerson.TabIndex = 0;
            btnCreatPerson.Text = "Create Person";
            btnCreatPerson.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(642, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(197, 29);
            txtSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(839, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 582);
            Controls.Add(panel1);
            Controls.Add(panelPerson);
            Name = "FormPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Info";
            panelPerson.ResumeLayout(false);
            panelPerson.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPerson;
        private Label label1;
        private Panel panel1;
        private Button btnCreatPerson;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private DataGridView dgvPersons;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewButtonColumn Column10;
        private DataGridViewButtonColumn Column11;
    }
}