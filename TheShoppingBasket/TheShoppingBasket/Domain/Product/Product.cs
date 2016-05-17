namespace TheShoppingBasket.Domain.Product
{
    public abstract class Product
    {
        private int _quantity = 0;

        public abstract Money Cost();

        public void AddQuantity(int quantity)
        {
            _quantity += quantity;
        }
    }
}