using Buisnessapplication.BL;
using Buisnessapplication.DL;

namespace GraphicalUserInterface_Application
{
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }
        public static void AddAdmin()
        {
            UserBL admin = new UserBL("ahmad", "123", "admin");
            Admin.addUserIntoList(admin);
            UserDL.UserFile_Store(View_Customers.Userpath);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Delete_Book();
            f.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Main_Form();
            f.Show();
            this.Hide();
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new AddingBook_Form();
            f.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Add_Customer();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Add_Manager();
            f.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Notices();
            form.Show();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new View_Books();
            f.Show();
            this.Hide();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Form f = new View_Customers();
            f.Show();
            this.Hide();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new View_Employee();
            f.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Form f = new Update_Book();
            f.Show();

            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new Remove_Manager();
            f.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new Remove_Customer();
            f.Show();
            this.Hide();
        }
    }
}