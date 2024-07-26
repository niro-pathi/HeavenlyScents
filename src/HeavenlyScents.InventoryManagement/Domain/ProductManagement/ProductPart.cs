using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenlyScents.InventoryManagement.Domain.ProductManagement
{
    public partial class Product
    {
        public static int StockThreshold = 5;

        public static void ChangeStockThreshold(int newStockThreshold)
        {
            if (newStockThreshold > StockThreshold)
                StockThreshold = newStockThreshold;
        }
        public void UpdateLowStock()
        {
            if (AmountInStock < StockThreshold) //for now hard coded value
            {
                IsBelowStockThreshold = true;
            }
        }
        protected object CreateSimpleProductRepresentation()
        {
            return $"Product {Id} ({Name})";
        }

        protected void Log(string message)
        {
            //this can be stream to a log file
            Console.WriteLine(message);
        }
    }
}
