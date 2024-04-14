namespace Session_9___Aflevering___AppStart
{
    partial class Form1
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
            btnSearchJsonLocation = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 164);
            label1.Name = "label1";
            label1.Size = new Size(256, 25);
            label1.TabIndex = 0;
            label1.Text = "Please point to .Json location";
            // 
            // btnSearchJsonLocation
            // 
            btnSearchJsonLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSearchJsonLocation.BackColor = Color.WhiteSmoke;
            btnSearchJsonLocation.BackgroundImageLayout = ImageLayout.Center;
            btnSearchJsonLocation.FlatStyle = FlatStyle.Flat;
            btnSearchJsonLocation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchJsonLocation.Location = new Point(330, 192);
            btnSearchJsonLocation.Name = "btnSearchJsonLocation";
            btnSearchJsonLocation.Size = new Size(101, 36);
            btnSearchJsonLocation.TabIndex = 1;
            btnSearchJsonLocation.Text = "Search";
            btnSearchJsonLocation.UseVisualStyleBackColor = false;
            btnSearchJsonLocation.Click += btnSearchJsonLocation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 204, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchJsonLocation);
            Controls.Add(label1);
            Name = "Form1";
            Text = "AppStart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSearchJsonLocation;
    }
}