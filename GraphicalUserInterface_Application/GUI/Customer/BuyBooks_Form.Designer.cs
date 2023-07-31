namespace GraphicalUserInterface_Application.GUI.Customer
{
    partial class BuyBooks_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBooks_Form));
            label7 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button12 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(421, 52);
            label7.Name = "label7";
            label7.Size = new Size(172, 51);
            label7.TabIndex = 93;
            label7.Text = "Buy Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(108, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 48);
            panel2.TabIndex = 88;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(548, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 92;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(548, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(245, 148);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 90;
            label1.Text = "Enter The Title Of The Book:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(-44, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 552);
            panel1.TabIndex = 89;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(31, 31);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 12;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(245, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 194);
            dataGridView1.TabIndex = 101;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(619, 225);
            button2.Name = "button2";
            button2.Size = new Size(122, 35);
            button2.TabIndex = 100;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(568, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 99;
            textBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(225, 275);
            label3.Name = "label3";
            label3.Size = new Size(285, 24);
            label3.TabIndex = 98;
            label3.Text = "Enter The The Quantity  to Buy";
            label3.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(223, 225);
            label9.Name = "label9";
            label9.Size = new Size(119, 19);
            label9.TabIndex = 97;
            label9.Text = "Book Not Found";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(245, 304);
            label8.Name = "label8";
            label8.Size = new Size(183, 19);
            label8.TabIndex = 96;
            label8.Text = "Book Bought Successfully";
            label8.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(619, 304);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 95;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(223, 188);
            label2.Name = "label2";
            label2.Size = new Size(287, 24);
            label2.TabIndex = 94;
            label2.Text = "Enter The Author Of The Book:";
            // 
            // BuyBooks_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 555);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuyBooks_Form";
            Text = "BuyBooks_Form";
            Load += BuyBooks_Form_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Button button12;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private Label label9;
        private Label label8;
        private Button button1;
        private Label label2;
    }
}