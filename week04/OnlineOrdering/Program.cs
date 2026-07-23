using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "123 Main Street",
            "Provo",
            "Utah",
            "USA"
        );


        Customer customer1 = new Customer(
            "Daniel Villacres",
            address1
        );


        Product product1 = new Product(
            "Laptop",
            "L001",
            900,
            1
        );


        Product product2 = new Product(
            "Mouse",
            "M001",
            25,
            2
        );


        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);



        Address address2 = new Address(
            "456 Green Street",
            "London",
            "England",
            "UK"
        );


        Customer customer2 = new Customer(
            "John Smith",
            address2
        );


        Product product3 = new Product(
            "Keyboard",
            "K001",
            50,
            3
        );


        Product product4 = new Product(
            "Monitor",
            "MO001",
            200,
            1
        );


        Order order2 = new Order(customer2);


        order2.AddProduct(product3);
        order2.AddProduct(product4);



        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        

        Console.WriteLine("------------------------------");


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());

    }
}