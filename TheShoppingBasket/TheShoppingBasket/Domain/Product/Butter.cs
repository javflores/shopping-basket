namespace TheShoppingBasket.Domain.Product
{
    public class Butter : Product
    {
        public override Money Price => new Money(0.80m);

        public Butter() : base("butter")
        {
        }
    }
}