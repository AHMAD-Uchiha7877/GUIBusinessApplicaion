namespace GraphicalUserInterface_Application
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(84, 170);
            button1.Name = "button1";
            button1.Size = new Size(227, 144);
            button1.TabIndex = 0;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumVioletRed;
            button2.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(396, 170);
            button2.Name = "button2";
            button2.Size = new Size(227, 144);
            button2.TabIndex = 1;
            button2.Text = "Manager";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkMagenta;
            button3.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(696, 170);
            button3.Name = "button3";
            button3.Size = new Size(227, 144);
            button3.TabIndex = 2;
            button3.Text = "Customer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(165, 41);
            label1.Name = "label1";
            label1.Size = new Size(170, 53);
            label1.TabIndex = 3;
            label1.Text = "Login As";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 507);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Main_Form";
            Text = "Main_Form";
            Load += Main_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}