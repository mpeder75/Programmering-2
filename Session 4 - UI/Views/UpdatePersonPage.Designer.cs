namespace Session_4___UI.Views
{
    partial class UpdatePersonPage
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
            label1 = new Label();
            label2 = new Label();
            txtUpdateFirstName = new TextBox();
            txtUpdateLastName = new TextBox();
            btnSaveChanges = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 134);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 178);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // txtUpdateFirstName
            // 
            txtUpdateFirstName.Location = new Point(223, 131);
            txtUpdateFirstName.Name = "txtUpdateFirstName";
            txtUpdateFirstName.Size = new Size(186, 23);
            txtUpdateFirstName.TabIndex = 2;
            // 
            // txtUpdateLastName
            // 
            txtUpdateLastName.Location = new Point(223, 170);
            txtUpdateLastName.Name = "txtUpdateLastName";
            txtUpdateLastName.Size = new Size(186, 23);
            txtUpdateLastName.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(200, 258);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(75, 23);
            btnSaveChanges.TabIndex = 4;
            btnSaveChanges.Text = "Save changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // UpdatePersonPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtUpdateLastName);
            Controls.Add(txtUpdateFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdatePersonPage";
            Text = "UpdatePersonPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUpdateFirstName;
        private TextBox txtUpdateLastName;
        private Button btnSaveChanges;
    }
}