using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Sofas
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class ModernSofa : ISofa
    {
        public string WhatAmI()
        {
            return "Modern Sofa";
        }
    }
}
