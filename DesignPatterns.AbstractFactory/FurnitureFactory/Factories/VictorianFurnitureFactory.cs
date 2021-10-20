using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Abstractions;
using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Chairs;
using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Sofas;
using DesignPatterns.AbstractFactory.FurnitureFactory.Products.Concrete.Table;

namespace DesignPatterns.AbstractFactory.FurnitureFactory.Factories
{
    // Concrete factories produce a family of products that belong
    // to a single variant. The factory guarantees that the
    // resulting products are compatible. Signatures of the concrete
    // factory's methods return an abstract product, while inside
    // the method a concrete product is instantiated.
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
