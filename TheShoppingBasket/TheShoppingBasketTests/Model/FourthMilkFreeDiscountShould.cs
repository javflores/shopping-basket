﻿using TheShoppingBasket.Model;
using Xunit;

namespace TheShoppingBasketTests.Model
{
    public class FourthMilkFreeDiscountShould
    {
        private readonly Discount _fourthMilkFreeDiscount = new FourthMilkFreeDiscount();

        [Theory]
        [InlineData(3, 0)]
        [InlineData(4, 1.15)]
        [InlineData(5, 1.15)]
        [InlineData(8, 2.30)]
        [InlineData(12, 3.45)]
        [InlineData(14, 3.45)]
        public void discount_4th_milk(int quantity, decimal expectedDiscount)
        {
            Products products = new Products();
            AddMilks(products, quantity);

            Money discount = _fourthMilkFreeDiscount.Apply(products);

            Assert.Equal(new Money(expectedDiscount), discount);
        }

        private void AddMilks(Products products, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                products.Add(new Product("milk"));
            }
        }
    }
}