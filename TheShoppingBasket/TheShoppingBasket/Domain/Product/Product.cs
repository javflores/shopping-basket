namespace TheShoppingBasket.Domain.Product
{
    public class Product
    {
        private readonly string _name;

        public Product(string name)
        {
            _name = name;
        }

        public virtual Money Cost()
        {
            return new Money();
        }

        public override bool Equals(object anotherProduct)
        {
            return ((Product)anotherProduct)._name == _name;
        }

        public static implicit operator string(Product product)
        {
            return product._name;
        }
    }
}