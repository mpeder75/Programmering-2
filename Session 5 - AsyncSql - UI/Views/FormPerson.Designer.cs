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
            panel1 = new Panel();
            label0 = new Label();
            panel2 = new Panel();
            btnSavePerson = new Button();
            txtPhone = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPostalCode = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(160, 113, 255);
            panel1.Controls.Add(label0);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 140);
            panel1.TabIndex = 0;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label0.ForeColor = Color.White;
            label0.Location = new Point(31, 55);
            label0.Name = "label0";
            label0.Size = new Size(89, 21);
            label0.TabIndex = 0;
            label0.Text = "Add Person";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSavePerson);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPostalCode);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCity);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(57, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 592);
            panel2.TabIndex = 0;
            // 
            // btnSavePerson
            // 
            btnSavePerson.BackColor = Color.FromArgb(160, 113, 255);
            btnSavePerson.FlatAppearance.BorderSize = 0;
            btnSavePerson.FlatStyle = FlatStyle.Flat;
            btnSavePerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSavePerson.ForeColor = Color.White;
            btnSavePerson.Location = new Point(83, 526);
            btnSavePerson.Name = "btnSavePerson";
            btnSavePerson.Size = new Size(86, 29);
            btnSavePerson.TabIndex = 8;
            btnSavePerson.Text = "Save";
            btnSavePerson.UseVisualStyleBackColor = false;
            btnSavePerson.Click += btnSavePersonClick;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(83, 477);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 23);
            txtPhone.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(83, 459);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 0;
            label8.Text = "Phone:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(83, 406);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 23);
            txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(83, 388);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostalCode.Location = new Point(83, 342);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(261, 23);
            txtPostalCode.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(83, 324);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 0;
            label6.Text = "Postalcode:";
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(83, 269);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(261, 23);
            txtCity.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 251);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "City:";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(83, 197);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(261, 23);
            txtAddress.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(83, 179);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "Address:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(83, 127);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(261, 23);
            txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 109);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Lastname:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(83, 58);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(261, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 40);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Firstname:";
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 812);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FormPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label0;
        private Panel panel2;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPostalCode;
        private Label label6;
        private TextBox txtCity;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPhone;
        private Label label8;
        private Button btnSavePerson;
    }
}