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
    public partial class View_Books : Form
    {
        public View_Books()
        {
            InitializeComponent();
        }
        public static string pathBook = "FileForStoreBooks.txt";
        private void View_Books_Load(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellErrorTextNeeded(object sender, DataGridViewCellErrorTextNeededEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
