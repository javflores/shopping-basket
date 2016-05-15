namespace TheShoppingBasket.Domain.Product
{
    public class Butter : Product
    {
        public Butter() : base("butter")
        {
        }

        public override Money Cost()
        {
            return new Money(0.80m);
        }
    }
}