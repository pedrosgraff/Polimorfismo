using System;
using System.Globalization;
using System.Security.Cryptography;
using HerancaPolimorfismo.Entities;


namespace HerancaPolimorfismo
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= qtd; i++)
            {
                Console.Write($"Product #{i} data ");
                Console.Write("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double cf = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, cf));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufecture date ) DD/MM/YYYY) ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add( new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }


            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }

        }
    }
}