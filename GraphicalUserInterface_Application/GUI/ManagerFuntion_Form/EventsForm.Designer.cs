namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button12 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Location = new Point(159, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 68);
            panel2.TabIndex = 57;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(698, 221);
            button3.Name = "button3";
            button3.Size = new Size(193, 122);
            button3.TabIndex = 56;
            button3.Text = "Cancel Event";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(448, 221);
            button2.Name = "button2";
            button2.Size = new Size(193, 122);
            button2.TabIndex = 55;
            button2.Text = "View Events";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(200, 221);
            button1.Name = "button1";
            button1.Size = new Size(193, 122);
            button1.TabIndex = 54;
            button1.Text = "Schedule Event";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(406, 94);
            label1.Name = "label1";
            label1.Size = new Size(282, 36);
            label1.TabIndex = 59;
            label1.Text = "Events Managment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button12);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 552);
            panel1.TabIndex = 58;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 555);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EventsForm";
            Text = "EventsForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button12;
        private Label label1;
        private Panel panel1;
    }
}