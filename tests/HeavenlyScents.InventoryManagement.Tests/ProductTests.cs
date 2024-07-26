using HeavenlyScents.InventoryManagement.Domain.ProductManagement;

namespace HeavenlyScents.InventoryManagement.Tests
{
    public class ProductTests
    {
        [Fact]
        public void UseProduct_Reduce_AmountInStock()
        {
            //Arrange
            Product product = new Product(1, "Wax", "Soy Wax", new Domain.General.Price() { ItemPrice = 43, Currency = Domain.General.Currency.Dollar }, UnitType.PerKg, 100);

            product.IncreaseStock(100);

            //Action
            product.UseProduct(20);

            //Assert
            Assert.Equal(80, product.AmountInStock);
        }

        [Fact]
        public void UseProduct_ItemHigherThanStock_NoChangeStock()
        {
            //Arrange
            Product product = new Product(1, "Wax", "Soy Wax", new Domain.General.Price() { ItemPrice = 43, Currency = Domain.General.Currency.Dollar }, UnitType.PerKg, 100);

            product.IncreaseStock(10);

            //Action
            product.UseProduct(100);

            //Assert
            Assert.Equal(10, product.AmountInStock);
        }

        [Fact]
        public void UseProduct_Reduces_AmountStock_StockBellowThreshold()
        {
            //Arrange
            Product product = new Product(1, "Wax", "Soy Wax", new Domain.General.Price() { ItemPrice = 43, Currency = Domain.General.Currency.Dollar }, UnitType.PerKg, 100);

            int increaseValue = 100;
            product.IncreaseStock(increaseValue);

            //Action
            product.UseProduct(increaseValue - 1);

            //Assert
            Assert.True(product.IsBelowStockThreshold);
        }
    }

}