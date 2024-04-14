namespace Session_9___AfleveringV2
{
    partial class DetailsMovie
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
            panel1 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            btnPrint = new Button();
            btnBack = new Button();
            label1 = new Label();
            lblOverviewTitle = new Label();
            lblReleaseDate = new Label();
            picFront = new PictureBox();
            txtOverview = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFront).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 204, 255);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 100);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(25, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblOverviewTitle);
            panel2.Controls.Add(lblReleaseDate);
            panel2.Controls.Add(picFront);
            panel2.Controls.Add(txtOverview);
            panel2.Location = new Point(25, 123);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 803);
            panel2.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(185, 748);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(105, 34);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(36, 748);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 34);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 1;
            label1.Text = "Release date:";
            // 
            // lblOverviewTitle
            // 
            lblOverviewTitle.AutoSize = true;
            lblOverviewTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOverviewTitle.Location = new Point(36, 91);
            lblOverviewTitle.Name = "lblOverviewTitle";
            lblOverviewTitle.Size = new Size(112, 25);
            lblOverviewTitle.TabIndex = 0;
            lblOverviewTitle.Text = "Description:";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDate.Location = new Point(155, 38);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(135, 25);
            lblReleaseDate.TabIndex = 0;
            lblReleaseDate.Text = "lblReleaseDate";
            // 
            // picFront
            // 
            picFront.Location = new Point(469, 32);
            picFront.Name = "picFront";
            picFront.Size = new Size(500, 750);
            picFront.SizeMode = PictureBoxSizeMode.AutoSize;
            picFront.TabIndex = 0;
            picFront.TabStop = false;
            // 
            // txtOverview
            // 
            txtOverview.BackColor = Color.White;
            txtOverview.BorderStyle = BorderStyle.None;
            txtOverview.CausesValidation = false;
            txtOverview.Enabled = false;
            txtOverview.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverview.ForeColor = Color.Black;
            txtOverview.Location = new Point(36, 115);
            txtOverview.Multiline = true;
            txtOverview.Name = "txtOverview";
            txtOverview.ReadOnly = true;
            txtOverview.Size = new Size(389, 305);
            txtOverview.TabIndex = 0;
            // 
            // DetailsMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1056, 963);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DetailsMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailsMovie";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Label lblOverviewTitle;
        private Label lblReleaseDate;
        private PictureBox picFront;
        private TextBox txtOverview;
        private Label label1;
        private Button btnBack;
        private Button btnPrint;
    }
}