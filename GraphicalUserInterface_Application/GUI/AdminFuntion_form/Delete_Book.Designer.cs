namespace GraphicalUserInterface_Application
{
    partial class Delete_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Book));
            label7 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button12 = new Button();
            label2 = new Label();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(463, 51);
            label7.Name = "label7";
            label7.Size = new Size(206, 51);
            label7.TabIndex = 79;
            label7.Text = "Delete Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(150, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 48);
            panel2.TabIndex = 73;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(443, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 78;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(443, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(158, 147);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 75;
            label1.Text = "Enter The Title Of The Book:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(158, 191);
            label2.Name = "label2";
            label2.Size = new Size(287, 24);
            label2.TabIndex = 80;
            label2.Text = "Enter The Author Of The Book:";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(514, 294);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 81;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(210, 233);
            label9.Name = "label9";
            label9.Size = new Size(119, 19);
            label9.TabIndex = 83;
            label9.Text = "Book Not Found";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(463, 348);
            label8.Name = "label8";
            label8.Size = new Size(181, 19);
            label8.TabIndex = 82;
            label8.Text = "Book Deleted Sucessfully";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(150, 261);
            label3.Name = "label3";
            label3.Size = new Size(311, 24);
            label3.TabIndex = 84;
            label3.Text = "Enter The The Quantity  to Delete:";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(463, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 85;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(514, 224);
            button2.Name = "button2";
            button2.Size = new Size(122, 35);
            button2.TabIndex = 86;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(663, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(345, 266);
            dataGridView1.TabIndex = 87;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Delete_Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 553);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Delete_Book";
            Text = "Delete_Book";
            Load += Delete_Book_Load;
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
        private Label label2;
        private Button button1;
        private Label label9;
        private Label label8;
        private Button button12;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}