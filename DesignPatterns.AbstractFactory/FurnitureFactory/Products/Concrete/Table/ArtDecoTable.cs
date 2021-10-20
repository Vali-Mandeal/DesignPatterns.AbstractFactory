using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Table
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class ArtDecoTable : ITable
    {
        public string WhatAmI()
        {
            return "Art Deco Table";
        }
    }
}
