using System;
using System.Collections.Generic;
using System.Globalization;
using Udemy.EntitiesProduct;

namespace Udemy
    {
    class Program
        {
        static void Main(string[] args)
            {
            List<Product> prodList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resposta = char.Parse(Console.ReadLine());
                while (resposta != 'c' && resposta != 'i' && resposta != 'u')
                    {
                    Console.Write("Invalid character. Select one of the following options (c/u/i): ");
                    resposta = char.Parse(Console.ReadLine());
                    }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'c')
                    {
                    prodList.Add(new Product(name, price));
                    }

                else if (resposta == 'i')
                    {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    prodList.Add(new ImportedProduct(name, price, customsFee));
                    }
                else if (resposta == 'u')
                    {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());
                    prodList.Add(new UsedProduct(name, price, dateTime));
                    }
                }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product priceTagList in prodList)
                {
                Console.WriteLine(priceTagList.PriceTag());
                }

            }
        }
    }