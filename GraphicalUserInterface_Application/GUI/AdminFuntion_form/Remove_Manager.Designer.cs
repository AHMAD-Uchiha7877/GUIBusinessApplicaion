namespace GraphicalUserInterface_Application
{
    partial class Remove_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Manager));
            label7 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button12 = new Button();
            button1 = new Button();
            label2 = new Label();
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
            label7.Location = new Point(400, 75);
            label7.Name = "label7";
            label7.Size = new Size(273, 51);
            label7.TabIndex = 86;
            label7.Text = "Remove Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(150, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 48);
            panel2.TabIndex = 81;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 84;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(178, 149);
            label1.Name = "label1";
            label1.Size = new Size(318, 24);
            label1.TabIndex = 83;
            label1.Text = "Enter The Name Of The Manager: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 552);
            panel1.TabIndex = 82;
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
            button12.Location = new Point(14, 42);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 87;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(339, 217);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 87;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(270, 253);
            label2.Name = "label2";
            label2.Size = new Size(144, 19);
            label2.TabIndex = 88;
            label2.Text = "Removed Succesfuly";
            label2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(461, 264);
            dataGridView1.TabIndex = 90;
            // 
            // Remove_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 553);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Remove_Manager";
            Text = "Remove_Manager";
            Load += Remove_Manager_Load;
            panel1.ResumeLayout(false);
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
        private Button button12;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}