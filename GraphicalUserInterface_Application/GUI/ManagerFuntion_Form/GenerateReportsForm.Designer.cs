namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    partial class GenerateReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReportsForm));
            button1 = new Button();
            button12 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(674, 367);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 90;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button12.Location = new Point(22, 30);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 13;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(603, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 23);
            textBox4.TabIndex = 93;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(281, 274);
            label4.Name = "label4";
            label4.Size = new Size(245, 24);
            label4.TabIndex = 92;
            label4.Text = "Enter the number of loans:";
            label4.Click += label4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(603, 434);
            label8.Name = "label8";
            label8.Size = new Size(196, 19);
            label8.TabIndex = 91;
            label8.Text = "Manager Added Sucessfully";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(444, 86);
            label7.Name = "label7";
            label7.Size = new Size(134, 51);
            label7.TabIndex = 89;
            label7.Text = "Reports";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(159, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 43);
            panel2.TabIndex = 81;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(603, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 88;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(603, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 86;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(187, 234);
            label3.Name = "label3";
            label3.Size = new Size(339, 24);
            label3.TabIndex = 85;
            label3.Text = "Enter the number of borrowed books: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(375, 185);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 83;
            label1.Text = "Enter The Date:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 552);
            panel1.TabIndex = 82;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(234, 322);
            label5.Name = "label5";
            label5.Size = new Size(283, 24);
            label5.TabIndex = 94;
            label5.Text = "Enter the number of lost books:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(603, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(193, 23);
            textBox5.TabIndex = 95;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // GenerateReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 555);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenerateReportsForm";
            Text = "GenerateReportsForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button12;
        private TextBox textBox4;
        private Label label4;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private TextBox textBox5;
    }
}