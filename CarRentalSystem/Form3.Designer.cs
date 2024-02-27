namespace csc221CarRentalSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.carIDcomboBox = new System.Windows.Forms.ComboBox();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.rentalDate = new System.Windows.Forms.DateTimePicker();
            this.rentButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.colorCombo = new System.Windows.Forms.ComboBox();
            this.carModelCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.caRentalLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.carIDcomboBox);
            this.panel1.Controls.Add(this.returnDate);
            this.panel1.Controls.Add(this.rentalDate);
            this.panel1.Controls.Add(this.rentButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.colorCombo);
            this.panel1.Controls.Add(this.carModelCombo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 454);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rent a Car";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Gray;
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.DarkRed;
            this.nextButton.Location = new System.Drawing.Point(619, 87);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 28);
            this.nextButton.TabIndex = 56;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // carIDcomboBox
            // 
            this.carIDcomboBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDcomboBox.FormattingEnabled = true;
            this.carIDcomboBox.Items.AddRange(new object[] {
            "ADF152",
            "BCG487",
            "ETK286",
            "FDT568",
            "GSD658",
            "KGH897",
            "NFK579",
            "RHK489",
            "UFG865",
            "ZTR748",
            "BKD679",
            "ATR492",
            "CDJ824",
            "RSQ382"});
            this.carIDcomboBox.Location = new System.Drawing.Point(130, 123);
            this.carIDcomboBox.Name = "carIDcomboBox";
            this.carIDcomboBox.Size = new System.Drawing.Size(121, 26);
            this.carIDcomboBox.TabIndex = 55;
            // 
            // returnDate
            // 
            this.returnDate.CustomFormat = "dd-MM-yyyy";
            this.returnDate.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate.Location = new System.Drawing.Point(130, 317);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(121, 25);
            this.returnDate.TabIndex = 50;
            // 
            // rentalDate
            // 
            this.rentalDate.CustomFormat = "dd-MM-yyyy";
            this.rentalDate.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentalDate.Location = new System.Drawing.Point(130, 277);
            this.rentalDate.Name = "rentalDate";
            this.rentalDate.Size = new System.Drawing.Size(121, 25);
            this.rentalDate.TabIndex = 49;
            // 
            // rentButton
            // 
            this.rentButton.BackColor = System.Drawing.Color.Gray;
            this.rentButton.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentButton.ForeColor = System.Drawing.Color.Black;
            this.rentButton.Location = new System.Drawing.Point(317, 342);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(109, 39);
            this.rentButton.TabIndex = 35;
            this.rentButton.Text = "Rent car";
            this.rentButton.UseVisualStyleBackColor = false;
            this.rentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(226, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "What car would you like to rent?";
            // 
            // colorCombo
            // 
            this.colorCombo.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCombo.FormattingEnabled = true;
            this.colorCombo.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black",
            "Purple",
            "White",
            "Yellow",
            "Green",
            "Maroon",
            "Orange",
            "Silver",
            ""});
            this.colorCombo.Location = new System.Drawing.Point(130, 219);
            this.colorCombo.Name = "colorCombo";
            this.colorCombo.Size = new System.Drawing.Size(121, 26);
            this.colorCombo.TabIndex = 47;
            // 
            // carModelCombo
            // 
            this.carModelCombo.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelCombo.FormattingEnabled = true;
            this.carModelCombo.Items.AddRange(new object[] {
            "Kia",
            "Sports car",
            "Toyota",
            "Nissan",
            "Honda",
            "Tesla",
            "Lexus RX",
            "Acura",
            "Coupe",
            "Corvette",
            "Bently",
            "BMW X5"});
            this.carModelCombo.Location = new System.Drawing.Point(130, 175);
            this.carModelCombo.Name = "carModelCombo";
            this.carModelCombo.Size = new System.Drawing.Size(121, 26);
            this.carModelCombo.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(16, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(21, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Rental Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(42, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(31, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Car Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Car ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.caRentalLabel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-4, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 43);
            this.panel2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(553, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            // 
            // caRentalLabel
            // 
            this.caRentalLabel.AutoSize = true;
            this.caRentalLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caRentalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.caRentalLabel.Location = new System.Drawing.Point(130, 3);
            this.caRentalLabel.Name = "caRentalLabel";
            this.caRentalLabel.Size = new System.Drawing.Size(221, 34);
            this.caRentalLabel.TabIndex = 2;
            this.caRentalLabel.Text = "Car Rental System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(495, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DateTimePicker rentalDate;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox colorCombo;
        private System.Windows.Forms.ComboBox carModelCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label caRentalLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox carIDcomboBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label5;
    }
}