namespace GraphicalUserInterface_Application
{
    partial class Notices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notices));
            label7 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button12 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(426, 111);
            label7.Name = "label7";
            label7.Size = new Size(154, 51);
            label7.TabIndex = 79;
            label7.Text = "NOTICES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(150, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 48);
            panel2.TabIndex = 73;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 552);
            panel1.TabIndex = 74;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.FlatAppearance.BorderColor = Color.Red;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.Red;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(14, 41);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 13;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(241, 223);
            button1.Name = "button1";
            button1.Size = new Size(138, 97);
            button1.TabIndex = 80;
            button1.Text = "Add Notices";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(460, 211);
            button2.Name = "button2";
            button2.Size = new Size(138, 125);
            button2.TabIndex = 81;
            button2.Text = "View Notices";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(676, 223);
            button3.Name = "button3";
            button3.Size = new Size(138, 97);
            button3.TabIndex = 82;
            button3.Text = "Delete Notices";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Notices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 553);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notices";
            Text = "Notices";
            Load += Notices_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button12;
    }
}