using Session_6___ContosoPizza.Data;
using Session_6___ContosoPizza.Models;

// Instans af ContextDb
using ContosoPizzaContext context = new ContosoPizzaContext();

// Produkt objekt oprettes
Product veggieSpecial = new Product() 
{
    Name = "VeggieSpecial",
    Price = 9.99M
};

// veggieSpecial tilføjes til Product
context.Products.Add(veggieSpecial);

Product deLusxMeat = new Product()
{
    Name = "Deluxe Meat Spacial",
    Price = 12.99M
};
context.Products.Add(deLusxMeat);

// data persistes til database
context.SaveChanges();


// -------------- Læse data fra Db med "fluent API" --------------- //

// Søge efter vare, hvis pris er større end 10, og sorter efter navn

var result = context.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name);

foreach (Product p in result)
{
    Console.WriteLine($"Id:     {p.Id}");
    Console.WriteLine($"Name:   {p.Name}");
    Console.WriteLine($"Price:     {p.Price}");
    Console.WriteLine(new string('_', 30));
}


// ---------------------- SLET en entiti i databasen ------------- //
context.Remove(deLusxMeat);