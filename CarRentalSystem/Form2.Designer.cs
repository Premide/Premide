namespace csc221CarRentalSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rentrecordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.phonenotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userIdtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.rentrecords = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rentrecords);
            this.panel1.Controls.Add(this.rentrecordButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clickButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.phonenotextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailtextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.userIdtextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nametextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 452);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(710, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 75;
            this.label5.Text = "Optional";
            // 
            // rentrecordButton
            // 
            this.rentrecordButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rentrecordButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentrecordButton.ForeColor = System.Drawing.Color.Black;
            this.rentrecordButton.Location = new System.Drawing.Point(676, 49);
            this.rentrecordButton.Name = "rentrecordButton";
            this.rentrecordButton.Size = new System.Drawing.Size(170, 34);
            this.rentrecordButton.TabIndex = 73;
            this.rentrecordButton.Text = "View rental records";
            this.rentrecordButton.UseVisualStyleBackColor = false;
            this.rentrecordButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Choose a car(click)";
            // 
            // clickButton
            // 
            this.clickButton.Image = ((System.Drawing.Image)(resources.GetObject("clickButton.Image")));
            this.clickButton.Location = new System.Drawing.Point(68, 153);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(161, 102);
            this.clickButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickButton.TabIndex = 71;
            this.clickButton.TabStop = false;
            this.clickButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(838, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 30);
            this.exitButton.TabIndex = 69;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(294, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Car Rental System";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.registerButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(454, 364);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(133, 34);
            this.registerButton.TabIndex = 60;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(209, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Phone number";
            // 
            // phonenotextBox
            // 
            this.phonenotextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenotextBox.Location = new System.Drawing.Point(341, 286);
            this.phonenotextBox.Name = "phonenotextBox";
            this.phonenotextBox.Size = new System.Drawing.Size(195, 26);
            this.phonenotextBox.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(270, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Email";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(340, 238);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(196, 26);
            this.emailtextBox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(251, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "User ID";
            // 
            // userIdtextBox
            // 
            this.userIdtextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdtextBox.Location = new System.Drawing.Point(340, 182);
            this.userIdtextBox.Name = "userIdtextBox";
            this.userIdtextBox.Size = new System.Drawing.Size(196, 26);
            this.userIdtextBox.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(266, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(340, 127);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(196, 26);
            this.nametextBox.TabIndex = 61;
            // 
            // rentrecords
            // 
            this.rentrecords.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rentrecords.HideSelection = false;
            this.rentrecords.Location = new System.Drawing.Point(656, 97);
            this.rentrecords.Name = "rentrecords";
            this.rentrecords.Size = new System.Drawing.Size(217, 301);
            this.rentrecords.TabIndex = 74;
            this.rentrecords.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox clickButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phonenotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userIdtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rentrecordButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView rentrecords;
    }
}