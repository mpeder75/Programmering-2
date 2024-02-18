namespace Session_3___Aflevering___Forms___UI.Views
{
    partial class CreatePerson
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnCreateNewPerson = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 99);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 140);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(217, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(217, 137);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(160, 23);
            txtLastName.TabIndex = 3;
            // 
            // btnCreateNewPerson
            // 
            btnCreateNewPerson.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateNewPerson.Location = new Point(217, 190);
            btnCreateNewPerson.Name = "btnCreateNewPerson";
            btnCreateNewPerson.Size = new Size(160, 66);
            btnCreateNewPerson.TabIndex = 4;
            btnCreateNewPerson.Text = "Create Person";
            btnCreateNewPerson.UseVisualStyleBackColor = true;
            btnCreateNewPerson.Click += btnCreatePersonClick;
            // 
            // CreatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateNewPerson);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreatePerson";
            Text = "CreatePerson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnCreateNewPerson;
    }
}