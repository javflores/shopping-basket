namespace TheShoppingBasket.Domain.Product
{
    public abstract class Product
    {
        public int Quantity;

        public abstract Money Price { get; }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public Money Cost()
        {
            return Price*Quantity;
        }
    }
}