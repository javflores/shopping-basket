namespace TheShoppingBasket
{
    public class Money
    {
        private readonly decimal _amount;

        public Money(decimal amount)
        {
            _amount = amount;
        }

        public override bool Equals(object anotherMoney)
        {
            return ((Money)anotherMoney)._amount == _amount;
        }
    }
}