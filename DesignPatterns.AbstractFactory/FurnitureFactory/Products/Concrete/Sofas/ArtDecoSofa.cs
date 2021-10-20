using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Sofas
{
    // Concrete products are created by their corresponding concrete
    // factories.
    public class ArtDecoSofa : ISofa
    {
        public string WhatAmI()
        {
            return "Art Deco Sofa";
        }
    }
}
