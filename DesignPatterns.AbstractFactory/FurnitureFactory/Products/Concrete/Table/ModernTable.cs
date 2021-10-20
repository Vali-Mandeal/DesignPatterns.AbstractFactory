using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Table
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class ModernTable : ITable
    {
        public string WhatAmI()
        {
            return "Modern Table";
        }
    }
}
