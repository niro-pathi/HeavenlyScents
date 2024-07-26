using HeavenlyScents.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenlyScents.InventoryManagement.Domain.ProductManagement
{
    public class FreshProduct : Product
    {
        public DateTime ExpiryDateTime { get; set; }
        public string? StorageInstructions { get; set; }

        public FreshProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : 
            base(id, name, description, price, unitType, maxAmountInStock)
        {
        }
        public override void IncreaseStock()
        {
            AmountInStock++;
        }



        public override string DisplayDetailsFull()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Id} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");


            if (IsBelowStockThreshold)
            {
                sb.AppendLine("\n!!STOCK LOW!!");
            }

            sb.AppendLine("Storage instructions: " + StorageInstructions);//since this line needs to go here, we can't call the base here
            sb.AppendLine("Expiry date: " + ExpiryDateTime.ToShortDateString());

            return sb.ToString();
        }

    }
}
