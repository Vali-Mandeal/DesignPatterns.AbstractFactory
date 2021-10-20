using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Table
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class VictorianTable : ITable
    {
        public string WhatAmI()
        {
            return "Victorian Table";
        }
    }
}
