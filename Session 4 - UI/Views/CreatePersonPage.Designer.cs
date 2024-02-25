namespace Session_4___UI.Views
{
    partial class CreatePersonPage
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
            btnCreatePerson = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 92);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 136);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Last name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(229, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(229, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 23);
            txtLastName.TabIndex = 2;
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.Location = new Point(158, 265);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(101, 38);
            btnCreatePerson.TabIndex = 3;
            btnCreatePerson.Text = "CreateAsync Person";
            btnCreatePerson.UseVisualStyleBackColor = true;
            btnCreatePerson.Click += btnCreatePerson_Click;
            // 
            // CreatePersonPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreatePerson);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreatePersonPage";
            Text = "CreatePersonPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnCreatePerson;
    }
}