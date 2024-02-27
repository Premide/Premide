namespace csc221CarRentalSystem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalcostButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colortextBox = new System.Windows.Forms.TextBox();
            this.modeltextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carIDtextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.totalcostButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.colortextBox);
            this.panel1.Controls.Add(this.modeltextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.carIDtextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 468);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(465, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "NB: If there is no total cost, car chosen is not available";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(786, 52);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 29);
            this.exitButton.TabIndex = 57;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalcostButton
            // 
            this.totalcostButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.totalcostButton.Font = new System.Drawing.Font("Baskerville Old Face", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcostButton.Location = new System.Drawing.Point(546, 257);
            this.totalcostButton.Name = "totalcostButton";
            this.totalcostButton.Size = new System.Drawing.Size(188, 34);
            this.totalcostButton.TabIndex = 56;
            this.totalcostButton.Text = "Check total Cost";
            this.totalcostButton.UseVisualStyleBackColor = false;
            this.totalcostButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(205, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(540, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 50;
            // 
            // colortextBox
            // 
            this.colortextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colortextBox.Location = new System.Drawing.Point(286, 242);
            this.colortextBox.Name = "colortextBox";
            this.colortextBox.Size = new System.Drawing.Size(98, 26);
            this.colortextBox.TabIndex = 41;
            // 
            // modeltextBox
            // 
            this.modeltextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltextBox.Location = new System.Drawing.Point(286, 174);
            this.modeltextBox.Name = "modeltextBox";
            this.modeltextBox.Size = new System.Drawing.Size(98, 26);
            this.modeltextBox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(175, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Car Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(205, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "CarID";
            // 
            // carIDtextBox
            // 
            this.carIDtextBox.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDtextBox.Location = new System.Drawing.Point(286, 104);
            this.carIDtextBox.Name = "carIDtextBox";
            this.carIDtextBox.Size = new System.Drawing.Size(98, 26);
            this.carIDtextBox.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 43);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(666, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(535, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Billing Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(203, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Car Rental System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carIDtextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox colortextBox;
        private System.Windows.Forms.TextBox modeltextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button totalcostButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label7;
    }
}