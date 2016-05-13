﻿namespace TheShoppingBasket
{
    public class Product
    {
        private readonly string _name;

        public Product(string name)
        {
            _name = name;
        }

        public override bool Equals(object anotherProduct)
        {
            return ((Product)anotherProduct)._name == _name;
        }
    }
}