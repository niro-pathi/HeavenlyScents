﻿using HeavenlyScents.InventoryManagement.Domain.Contracts;
using HeavenlyScents.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HeavenlyScents.InventoryManagement.Domain.ProductManagement
{
    public class RegularProduct: Product, ISaveable
    {
        public RegularProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : 
            base(id, name, description, price, unitType, maxAmountInStock)
        {
        }

        public override void IncreaseStock()
        {
            AmountInStock++;
        }

        public string ConvertToStringForSaving()
        {
            return $"{Id};{Name};{Description};{maxItemsInStock};{Price.ItemPrice};{(int)Price.Currency};{(int)UnitType};1;";
        }

        public override object Clone()
        {
            return new RegularProduct(0, this.Name, this.Description, new Price() { ItemPrice = this.Price.ItemPrice, Currency = this.Price.Currency }, this.UnitType, this.maxItemsInStock);

        }
    }
}
