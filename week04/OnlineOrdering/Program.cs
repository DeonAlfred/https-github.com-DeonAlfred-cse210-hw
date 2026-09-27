using System;

class Program
{
    static void Main(string[] args)
    {
        //customer no 1
        Address addressl = new Address
        (
         "123 Main street",
        "Seattle" ,
         "Washington" ,
         "USA"
        );

        Customer customerone = new Customer
        (
            "Alex Winston",
            addressl
        );

        Product product1 = new Product
        (
            "Laptop",
            "P001",
             899,1
        );


         Product product2= new Product
        (
            "Mouse",
            "P002",
             899,2
        );


        Product product3 = new Product
        (
            "Keyboard",
            "P003",
             899,1
        );

        // Order1
        Order  order1 = new Order(customerone);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
 //customer no 2
        Address address2 = new Address
        (
         "144 Klein Drakenstein street",
         "Paarl" ,
         "Cape Town" ,
         "South Africa"
        );

        Customer customertwo = new Customer
        (
            "Mary Ashton",
            address2
        );
        
        Product product4 = new Product
        (
            "chair",
            "P004",
             100,
             2
        );


         Product product5= new Product
        (
            "Mic",
            "P005",
             120,2
        );


        Product product6 = new Product
        (
            "Headphones",
            "P006",
             76.1,1
        );

        // Order2
        Order  order2 = new Order(customertwo);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // Display the orders
        Console.WriteLine("====================================================");
        Console.WriteLine("Order 1");
        Console.WriteLine("====================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");


        Console.WriteLine("====================================================");
        Console.WriteLine("Order 2");
        Console.WriteLine("====================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");





    }
}