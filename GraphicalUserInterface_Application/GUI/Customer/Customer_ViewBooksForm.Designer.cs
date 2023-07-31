namespace GraphicalUserInterface_Application.GUI.Customer
{
    partial class Customer_ViewBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_ViewBooksForm));
            label7 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button12 = new Button();
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
            label7.Location = new Point(409, 61);
            label7.Name = "label7";
            label7.Size = new Size(186, 51);
            label7.TabIndex = 49;
            label7.Text = "View Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(158, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 43);
            panel2.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 552);
            panel1.TabIndex = 48;
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
            button12.Location = new Point(11, 42);
            button12.Name = "button12";
            button12.Size = new Size(94, 52);
            button12.TabIndex = 47;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(232, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(640, 344);
            dataGridView1.TabIndex = 50;
            // 
            // Customer_ViewBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(934, 554);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_ViewBooksForm";
            Text = "Customer_ViewBooksForm";
            Load += Customer_ViewBooksForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel2;
        private Panel panel1;
        private Button button12;
        private DataGridView dataGridView1;
    }
}