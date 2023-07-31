using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application.GUI.Customer
{
    public partial class BuyBooks_Form : Form
    {
        public BuyBooks_Form()
        {
            InitializeComponent();
        }
        private string bookTitle;
        private string bookAuthor;
        private bool bookFound = false;
        private void button2_Click(object sender, EventArgs e)
        {
            bookTitle = textBox1.Text;
            bookAuthor = textBox2.Text;
            foreach (BookBL book in Admin.GetBookList())
            {
                if (bookTitle == book.GetBookTitle() && bookAuthor == book.GetBookAuthor())
                {
                    bookFound = true;

                }
            }
            if (bookFound == true)
            {
                label3.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label9.Visible = true;
            }
        }

        private void BuyBooks_Form_Load(object sender, EventArgs e)
        {

            List<BookBL> BookList = Admin.GetBookList();
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Author", "Author");
            dataGridView1.Columns.Add("Isbn", "Isbn");
            dataGridView1.Columns.Add("Edition", "Edition");
            dataGridView1.Columns.Add("Genre", "Genre");
            dataGridView1.Columns.Add("Quantity", "Quantity");

            dataGridView1.Columns["Title"].Width = 150;
            dataGridView1.Columns["Author"].Width = 150;
            dataGridView1.Columns["Isbn"].Width = 150;
            dataGridView1.Columns["Edition"].Width = 100;
            dataGridView1.Columns["Genre"].Width = 100;
            dataGridView1.Columns["Quantity"].Width = 100;


            dataGridView1.Rows.Clear();

            foreach (BookBL books in BookList)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell Title_Cell = new DataGridViewTextBoxCell();
                Title_Cell.Value = books.GetBookTitle();
                row.Cells.Add(Title_Cell);

                DataGridViewCell Author_Cell = new DataGridViewTextBoxCell();
                Author_Cell.Value = books.GetBookAuthor();
                row.Cells.Add(Author_Cell);

                DataGridViewCell Isbn_Cell = new DataGridViewTextBoxCell();
                Isbn_Cell.Value = books.GetIsbnNumber();
                row.Cells.Add(Isbn_Cell);

                DataGridViewCell Edition_Cell = new DataGridViewTextBoxCell();
                Edition_Cell.Value = books.GetEdition();
                row.Cells.Add(Edition_Cell);

                DataGridViewCell Genre_CEll = new DataGridViewTextBoxCell();
                Genre_CEll.Value = books.GetGenre();
                row.Cells.Add(Genre_CEll);

                DataGridViewCell quantity_Cell = new DataGridViewTextBoxCell();
                quantity_Cell.Value = books.GetQuantity();
                row.Cells.Add(quantity_Cell);

                dataGridView1.Rows.Add(row);
                dataGridView1.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookFound)
            {
                label3.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;

                string quantity = textBox3.Text;
                if (int.TryParse(quantity, out int BuyQunatity))
                {


                    foreach (BookBL book in Admin.GetBookList())
                    {

                        int currentQuantity = int.Parse(book.GetQuantity());
                        if (BuyQunatity <= currentQuantity)
                        {
                            int updatedQuantity = currentQuantity - BuyQunatity;
                            book.SetBookQuantity(updatedQuantity.ToString());
                            BookDL.DeleteDataBookInFile(View_Books.pathBook, Admin.GetBookList());
                            if (updatedQuantity == 0)
                            {
                                Admin.GetBookList().Remove(book);
                                BookDL.DeleteDataBookInFile(View_Books.pathBook, Admin.GetBookList());

                            }

                            label8.Visible = true;
                        }

                        break;

                    }

                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Form f = new CustomerFuntion_Form();
            f.Show();
            this.Hide();
        }
    }
}
