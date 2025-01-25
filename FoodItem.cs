using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3._2
{
    internal class FoodItem
    {// Properties to hold the food item details
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string ExpirationDate { get; set; }

        // Constructor to initialize the FoodItem object
        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            // Initialize properties using the constructor parameters
            this.Name = name;
            this.Category = category;
            this.Quantity = quantity;
            this.ExpirationDate = expirationDate;
        }
    }
}

