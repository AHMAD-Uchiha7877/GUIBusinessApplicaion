using System;

namespace Buisnessapplication.BL
{
    internal class MonthyReportBL
    {
        private string date;
        private string totalBudget;
        private string borrowBooks;
        private string loans;
        private string lostBooks;
        public MonthyReportBL(string date, string totalBudget, string borrowBooks, string loans, string lostBooks)
        {
            this.date = date;
            this.totalBudget = totalBudget;
            this.borrowBooks = borrowBooks;
            this.loans = loans;
            this.lostBooks = lostBooks;
        }

        public MonthyReportBL() { }

        internal Manager_BL Manager_BL
        {
            get => default;
            set
            {
            }
        }

        public string GetDate()
        {
            return date;
        }

        public bool SetDate(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                date = value;
                return true;
            }
            return false;
        }

        public string GetTotalBudget()
        {
            return totalBudget;
        }

        public bool SetTotalBudget(string budget)
        {
            if (budget != null)
            {
                this.totalBudget = budget;
                return true;
            }

            return false;
        }

        public string GetBorrowBooks()
        {
            return borrowBooks;
        }

        public bool SetBorrowBooks(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                borrowBooks = value;
                return true;
            }
            return false;
        }

        public string GetLoans()
        {
            return loans;
        }

        public bool SetLoans(string loan)
        {
            if (loan != null)
            {
                this.loans = loan;
                return true;
            }

            return false;
        }

        public string GetLostBooks()
        {
            return lostBooks;
        }

        public bool SetLostBooks(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                lostBooks = value;
                return true;
            }
            return false;
        }
    }
}
