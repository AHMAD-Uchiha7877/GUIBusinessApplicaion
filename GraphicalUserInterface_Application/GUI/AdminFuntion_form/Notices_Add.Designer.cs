namespace GraphicalUserInterface_Application
{
    partial class Notices_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notices_Add));
            label7 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button12 = new Button();
            label9 = new Label();
            label8 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(425, 81);
            label7.Name = "label7";
            label7.Size = new Size(197, 51);
            label7.TabIndex = 28;
            label7.Text = "Add Notices";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(158, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 43);
            panel2.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(491, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(491, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(324, 279);
            label3.Name = "label3";
            label3.Size = new Size(152, 24);
            label3.TabIndex = 18;
            label3.Text = "Enter The date :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(277, 218);
            label2.Name = "label2";
            label2.Size = new Size(199, 24);
            label2.TabIndex = 17;
            label2.Text = "Enter the description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(340, 166);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 16;
            label1.Text = "Enter the title:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 552);
            panel1.TabIndex = 15;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(24, 23);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 12;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(354, 369);
            label9.Name = "label9";
            label9.Size = new Size(99, 19);
            label9.TabIndex = 49;
            label9.Text = "Invalid Input!";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(506, 412);
            label8.Name = "label8";
            label8.Size = new Size(178, 19);
            label8.TabIndex = 48;
            label8.Text = "Notice Added Sucessfully";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(562, 353);
            button2.Name = "button2";
            button2.Size = new Size(122, 35);
            button2.TabIndex = 47;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(491, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 50;
            // 
            // Notices_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 553);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notices_Add";
            Text = "Notices_Add";
            Load += Notices_Add_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button12;
        private Label label9;
        private Label label8;
        private Button button2;
        private TextBox textBox3;
    }
}