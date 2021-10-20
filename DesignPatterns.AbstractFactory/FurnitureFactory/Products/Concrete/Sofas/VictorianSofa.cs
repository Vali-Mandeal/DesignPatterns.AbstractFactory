using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Sofas
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class VictorianSofa : ISofa
    {
        public string WhatAmI()
        {
            return "Victorian Sofa";
        }
    }
}
