using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.DL;
namespace Buisnessapplication.BL
{
    public class IventoryBL
    {

        private string quantity;
        private string condition;
        private string location;
        private string Title;
        public IventoryBL(string title, string quantity, string condition, string location)
        {
            Title = title;
            this.quantity = quantity;
            this.condition = condition;
            this.location = location;
        }
        public string GetCategory()
        {
            return Title;
        }
        public string GetTitleInventory()
        {
            return Title;
        }
        public bool SetTitle(string Title)
        {
            if (!string.IsNullOrEmpty(Title)  )
            {
                this.Title = Title;
                return true;
            }

            return false;
        }

        public IventoryBL()
        {
        }
        // Quantity property
        public string GetQuantity()
        {
            return quantity;
        }

        public bool SetQuantity(string quantity)
        {
            if (!string.IsNullOrEmpty(quantity) && int.TryParse(quantity, out int quantityValue) && quantityValue >= 0)
            {
                this.quantity = quantity;
                return true; 
            }

            return false; 
        }
        // Condition property
        public string GetCondition()
        {
            return condition;
        }

        public bool SetCondition(string condition)
        {
            if (!string.IsNullOrEmpty(condition))
            {
                this.condition = condition;
                return true; // Condition updated successfully
            }

            return false; // Invalid condition provided
        }
        // Location property
        public string GetLocation()
        {
            return location;
        }

        public bool SetLocation(string location)
        {
            if (!string.IsNullOrEmpty(location))
            {
                this.location = location;
                return true; // Location updated successfully
            }

            return false; // Invalid location provided
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

