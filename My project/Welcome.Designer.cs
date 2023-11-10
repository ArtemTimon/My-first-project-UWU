namespace My_project
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Chocolate = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WelcomeName = new System.Windows.Forms.Label();
            this.ColourPanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.ColourPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.ColourPanel);
            this.panel1.Controls.Add(this.StudentNumber);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 432);
            this.panel1.TabIndex = 0;
            // 
            // StudentNumber
            // 
            this.StudentNumber.AutoSize = true;
            this.StudentNumber.Location = new System.Drawing.Point(61, 398);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(35, 13);
            this.StudentNumber.TabIndex = 5;
            this.StudentNumber.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Chocolate);
            this.panel2.Controls.Add(this.Green);
            this.panel2.Controls.Add(this.Blue);
            this.panel2.Controls.Add(this.Red);
            this.panel2.Location = new System.Drawing.Point(23, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 217);
            this.panel2.TabIndex = 3;
            // 
            // Chocolate
            // 
            this.Chocolate.AutoSize = true;
            this.Chocolate.Location = new System.Drawing.Point(22, 142);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(73, 17);
            this.Chocolate.TabIndex = 6;
            this.Chocolate.TabStop = true;
            this.Chocolate.Text = "Chocolate";
            this.Chocolate.UseVisualStyleBackColor = true;
            this.Chocolate.CheckedChanged += new System.EventHandler(this.Chocolate_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(22, 41);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(54, 17);
            this.Green.TabIndex = 8;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(22, 108);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 5;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(22, 75);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(45, 17);
            this.Red.TabIndex = 4;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(307, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLICK ME!";
            this.label3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Have a nice day";
            // 
            // WelcomeName
            // 
            this.WelcomeName.AutoSize = true;
            this.WelcomeName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeName.Location = new System.Drawing.Point(18, 2);
            this.WelcomeName.Name = "WelcomeName";
            this.WelcomeName.Size = new System.Drawing.Size(227, 19);
            this.WelcomeName.TabIndex = 0;
            this.WelcomeName.Text = "Welcome Mr Anderson to MS 111";
            // 
            // ColourPanel
            // 
            this.ColourPanel.Controls.Add(this.WelcomeName);
            this.ColourPanel.Controls.Add(this.label2);
            this.ColourPanel.Location = new System.Drawing.Point(264, 61);
            this.ColourPanel.Name = "ColourPanel";
            this.ColourPanel.Size = new System.Drawing.Size(263, 55);
            this.ColourPanel.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(708, 399);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 21);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(708, 372);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(44, 21);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ColourPanel.ResumeLayout(false);
            this.ColourPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WelcomeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Chocolate;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StudentNumber;
        private System.Windows.Forms.Panel ColourPanel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}