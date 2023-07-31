namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    partial class DeleteReports_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteReports_form));
            button1 = new Button();
            button12 = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(265, 214);
            button1.Name = "button1";
            button1.Size = new Size(122, 35);
            button1.TabIndex = 161;
            button1.Text = "cancel";
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
            button12.Location = new Point(29, 94);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 13;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(143, -55);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 125);
            panel2.TabIndex = 156;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(222, 296);
            label8.Name = "label8";
            label8.Size = new Size(153, 19);
            label8.TabIndex = 162;
            label8.Text = " Canceled succesfuly!";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(421, 73);
            label7.Name = "label7";
            label7.Size = new Size(236, 51);
            label7.TabIndex = 160;
            label7.Text = "Delete Reports";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 159;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(173, 143);
            label1.Name = "label1";
            label1.Size = new Size(214, 24);
            label1.TabIndex = 158;
            label1.Text = "Enter The Reprt Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(-17, -58);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 670);
            panel1.TabIndex = 157;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(421, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(501, 266);
            dataGridView1.TabIndex = 163;
            // 
            // DeleteReports_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 555);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteReports_form";
            Text = "DeleteReports_form";
            Load += DeleteReports_form_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button12;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}