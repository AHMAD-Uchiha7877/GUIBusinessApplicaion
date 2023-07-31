using System;

namespace Buisnessapplication.BL
{
   public class BookBL
    {
        private string title;
        private string author;
        private string isbn;
        private string edition;
        private string genre;
        private string quantity;
        public BookBL()
        { }
        public BookBL(string title, string author, string isbn, string edition, string genre, string quantity)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.edition = edition;
            this.genre = genre;
            this.quantity = quantity;
        }

        public Admin Admin
        {
            get => default;
            set
            {
            }
        }

        public bool SetBookAuthor(string author)
        {

            if (author.Length <= 20 && !string.IsNullOrEmpty(author))
            {
                this.author = author;
                return true;
            }
            return false;

        }
        public bool SetBookEdition(string edition)
        {

            if (edition.Length <= 20 && !string.IsNullOrEmpty(edition))
            {
                this.edition = edition;
                return true;
            }
            return false;
        }
        public bool SetBookIsbn(string isbn)
        {

            if (isbn.Length <= 20 && !string.IsNullOrEmpty(isbn))
            {
                this.isbn = isbn;
                return true;
            }
            return false;
        }
        public bool SetBookGenre(string genre)
        {
            if (genre.Length <= 20 && !string.IsNullOrEmpty(genre))
            {
                this.genre = genre;
                return true;
            }
            return false;
        }
        public bool SetBooktitle(string title)
        {
            if (title.Length <= 40 && !string.IsNullOrEmpty(title))
            {
                this.title = title;
                return true;
            }
            return false;
        }
        public bool SetBookQuantity(string quantity)
        {
            if (!string.IsNullOrEmpty(quantity))
            {
                if (int.TryParse(quantity, out int parsedQuantity) && parsedQuantity > 0 && parsedQuantity < 100)
                {
                    this.quantity = quantity;
                    return true;
                }
            }
            return false;
        }
        public string GetBookTitle()
        {
            return title;
        }
        public string GetBookAuthor()
        {
            return author;
        }
        public string GetIsbnNumber()
        {
            return isbn;
        }
        public string GetEdition()
        {
            return edition;
        }
        public string GetGenre()
        {
            return genre;
        }
        public string GetQuantity()
        {
            return quantity;
        }


    }
}
