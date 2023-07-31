using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{
    class BudgetBL
    {
        public string Name { get; set; }
        private string price;
        private string totalBudget;
        public string Date { get; set; }
        public BudgetBL()
        { }
        // Constructor
        public BudgetBL(string name, string price, string date)
        {
            this.Date = date;
            Name = name;
            this.price = price;
        }
        // Getters and Setters
        public string GetName()
        {
            return Name;
        }
        public string GetPrice()
        {
            return price;
        }
        public string GetTotalBudget()
        {
            return totalBudget;
        }
        public bool SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
                return true;
            }
            return false;
        }
        public bool SetPrice(string price)
        {
            // Check if the input is a numeric value
            if (decimal.TryParse(price, out _))
            {
                this.price = price;
                return true;
            }
            return false;
        }
        public void SetTotalBudget(string totalBudget)
        {
            // Check if the input is a numeric value
            if (decimal.TryParse(totalBudget, out _))
                this.totalBudget = totalBudget;
        }
        public string GetDate()
        {
            return Date;
        }
        public bool SetDate(string date)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                Date = date;
                return true;
            }
            return false;
        }
        public decimal CalculateTotalBudget()
        {
            // Calculate the total budget by parsing the price and totalBudget strings to decimal
            if (decimal.TryParse(price, out decimal priceValue) && decimal.TryParse(totalBudget, out decimal totalBudgetValue))
            {
                return priceValue + totalBudgetValue;
            }
            return 0;
        }
        public string getTotalBudget()
        {
            // Calculate and return the total budget as a string
            decimal totalBudgetValue = CalculateTotalBudget();
            return totalBudgetValue.ToString();
        }

        internal Manager_BL Manager_BL
        {
            get => default;
            set
            {
            }
        }
    }
}
