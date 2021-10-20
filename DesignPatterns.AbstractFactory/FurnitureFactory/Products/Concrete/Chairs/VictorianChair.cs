using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Chairs
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class VictorianChair : IChair
    {
        public string WhatAmI()
        {
            return "Victorian Chair";
        }
    }
}
