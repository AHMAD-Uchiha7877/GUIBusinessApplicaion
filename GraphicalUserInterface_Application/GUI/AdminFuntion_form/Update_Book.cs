using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application
{
    public partial class Update_Book : Form
    {
        public Update_Book()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Book_Load(object sender, EventArgs e)
        {

            
            List<BookBL> BookList = Admin.GetBookList();
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Author", "Author");
            dataGridView1.Columns.Add("Isbn", "Isbn");
            dataGridView1.Columns.Add("Edition", "Edition");
            dataGridView1.Columns.Add("Genre", "Genre");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns["Title"].Width = 100;
            dataGridView1.Columns["Author"].Width = 100;
            dataGridView1.Columns["Isbn"].Width = 100;
            dataGridView1.Columns["Edition"].Width = 100;
            dataGridView1.Columns["Genre"].Width = 100;
            dataGridView1.Columns["Quantity"].Width = 100;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
       private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();
        }

        private string title;
        private string Author;
        private bool BookFound = false;
        private void button1_Click(object sender, EventArgs e)
        {
            title = textBox1.Text;
            Author = textBox2.Text;
            //  BookFound = false; 

            foreach (BookBL books in Admin.GetBookList())
            {
                if (title == books.GetBookTitle() && Author == books.GetBookAuthor())
                {
                    BookFound = true;
                    break;
                }
            }

            if (BookFound == true)
            {
                button2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                //  button12.Visible = true;
                if (textBox3.Text == "title")
                {
                    label4.Visible = true;
                    textBox4.Visible = true;
                    button2.Visible = true;
                }
                else if (textBox3.Text == "author")
                {
                    label5.Visible = true;
                    textBox5.Visible = true;
                    button2.Visible = true;
                }
                else if (textBox3.Text == "isbn")
                {
                    label8.Visible = true;
                    textBox7.Visible = true;
                    button2.Visible = true;
                }
                else if (textBox3.Text == "edition")
                {
                    label6.Visible = true;
                    textBox6.Visible = true;
                    button2.Visible = true;
                }
                else if (textBox3.Text == "genre")
                {
                    label10.Visible = true;
                    textBox9.Visible = true;
                    button2.Visible = true;
                }
                else if (textBox3.Text == "quantity")
                {
                    label9.Visible = true;
                    textBox8.Visible = true;
                    button2.Visible = true;
                }

            }
            else
            {

                label11.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updatedTitle = textBox4.Text;
            string Authorupdate = textBox5.Text;
            string ISbnUpdate = textBox7.Text;
            string EditionUpdate = textBox6.Text;
            string GenreUpdate = textBox9.Text;
            string QuantityUpdate = textBox8.Text;

            bool check = false; // Initialize check to false

            foreach (BookBL book in Admin.GetBookList())
            {
                if (textBox3.Text == "title")
                {
                    book.SetBooktitle(updatedTitle);
                    check = true; // Book is updated, set check to true
                    break;
                }
                else if (textBox3.Text == "author")
                {
                    book.SetBookAuthor(Authorupdate);
                    check = true; // Book is updated, set check to true
                    break;
                }
                else if (textBox3.Text == "isbn")
                {
                    book.SetBookIsbn(ISbnUpdate);
                    check = true; // Book is updated, set check to true
                    break;
                }
                else if (textBox3.Text == "edition")
                {
                    book.SetBookEdition(EditionUpdate);
                    check = true; // Book is updated, set check to true
                    break;
                }
                else if (textBox3.Text == "genre")
                {
                    book.SetBookGenre(GenreUpdate);
                    check = true;
                    break;
                }
                else if (textBox3.Text == "quantity")
                {
                    if (int.TryParse(QuantityUpdate, out int quantity) && quantity > 0 && quantity <= 100)
                    {
                        book.SetBookGenre(GenreUpdate);
                        check = true; // Book is updated, set check to true
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity. Quantity must be a number between 1 and 100.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method, as there was an error
                    }
                }
            }

            if (check == true)
            {
                // Book is updated, show the "Book updated successfully" label
                label12.Visible = true;
            }
            else
            {
                // Book not found or there was an error, show the "Book not found" label
                label11.Visible = true;
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
