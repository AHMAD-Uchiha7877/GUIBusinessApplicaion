namespace GraphicalUserInterface_Application
{
    partial class Delete_Notices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Notices));
            label7 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button12 = new Button();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
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
            label7.Location = new Point(409, 60);
            label7.Name = "label7";
            label7.Size = new Size(227, 51);
            label7.TabIndex = 37;
            label7.Text = "Delete Notices";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(158, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 43);
            panel2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 34;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(166, 139);
            label1.Name = "label1";
            label1.Size = new Size(339, 24);
            label1.TabIndex = 31;
            label1.Text = " Enter the title of the notice to remove:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 552);
            panel1.TabIndex = 30;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(22, 31);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 84;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(344, 406);
            label9.Name = "label9";
            label9.Size = new Size(119, 19);
            label9.TabIndex = 86;
            label9.Text = "Book Not Found";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(558, 406);
            label8.Name = "label8";
            label8.Size = new Size(181, 19);
            label8.TabIndex = 85;
            label8.Text = "Book Deleted Sucessfully";
            label8.Visible = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(332, 207);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 38;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(187, 287);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 86;
            label2.Text = "Not Found";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(236, 249);
            label3.Name = "label3";
            label3.Size = new Size(189, 19);
            label3.TabIndex = 85;
            label3.Text = "Notice Deleted Sucessfully";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(442, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 305);
            dataGridView1.TabIndex = 87;
            // 
            // Delete_Notices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 553);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Delete_Notices";
            Text = "Delete_Notices";
            Load += Delete_Notices_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button button12;
        private Label label9;
        private Label label8;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
    }
}