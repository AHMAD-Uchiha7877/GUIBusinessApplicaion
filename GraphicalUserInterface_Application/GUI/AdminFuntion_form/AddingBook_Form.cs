using Buisnessapplication.BL;
using Buisnessapplication.DL;
using Buisnessapplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application
{
    public partial class AddingBook_Form : Form
    {
        public AddingBook_Form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BookBL book = new BookBL();
            string title = textBox1.Text;
            string author = textBox2.Text;
            string isbn = textBox3.Text;
            string edition = textBox4.Text;
            string genre = textBox5.Text;
            string quantity = textBox6.Text;
            if (book.SetBookQuantity(quantity) && book.SetBooktitle(title) && book.SetBookAuthor(author) && book.SetBookEdition(edition) && book.SetBookGenre(genre) && book.SetBookIsbn(isbn))
            {
                book = new BookBL(title, author, isbn, edition, genre, quantity);
                Admin.AddBooksIntoList(book);
                BookDL.storeDataBookInFile(View_Books.pathBook, book);
                label8.Visible = true;
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();
        }
        private void AddingBook_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
