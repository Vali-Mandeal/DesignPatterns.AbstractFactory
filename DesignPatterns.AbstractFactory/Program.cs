using System;
using System.Collections.Generic;
using DesignPatterns.AbstractFactory.FurnitureFactory;
using DesignPatterns.AbstractFactory.FurnitureFactory.Factories;

namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        private static IFurnitureFactory _factory;
        private static readonly List<string> FurnitureTypes = new() { "Victorian", "Modern", "Art Deco" };

        private static void Main()
        {
            var userChoice = ReadUserChoice();

            SetFactoryType(userChoice);

            PrintFurnitureTypes(FurnitureTypes[userChoice - 1]);
        }

        private static int ReadUserChoice()
        {
            PrintAvailableChoices();
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void PrintAvailableChoices()
        {
            Console.WriteLine("What kind of furniture set would you like? \n");

            var index = 1;
            foreach (var type in FurnitureTypes)
            {
                Console.WriteLine($"{index} - {type}");
                index++;
            }

            Console.WriteLine();
        }

        // In a real world scenario, usually the factory type is being set
        // at application startup, by reading a configuration file
        // However, multiple choices are available based on scenario
        private static void SetFactoryType(int choice)
        {
            switch (choice)
            {
                case 1:
                    _factory = new VictorianFurnitureFactory();
                    break;
                case 2:
                    _factory = new ModernFurnitureFactory();
                    break;
                case 3:
                    _factory = new ArtDecoFurnitureFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        private static void PrintFurnitureTypes(string type)    
        {
            Console.WriteLine($"\nInside {type} collection we have:\n");

            Console.WriteLine(_factory.CreateChair().WhatAmI());
            Console.WriteLine(_factory.CreateSofa().WhatAmI());
            Console.WriteLine(_factory.CreateTable().WhatAmI());
        }
    }
}
