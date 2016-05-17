namespace TheShoppingBasket.Domain.Product
{
    class NullProduct : Product
    {
        public override Money Cost()
        {
            return new Money();
        }
    }
}
