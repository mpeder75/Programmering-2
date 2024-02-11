// Car objekter istancieres - Object initializer syntax
Car car1 = new Car() { Id = "1", Make = "BMW", Model = "M3" };
Car car2 = new Car() { Id = "2", Make = "Audi", Model = "A4" };

// Car objekter istancieres - Collection initializer syntax
List<Car> myList = new List<Car>()
{
    new Car { Id = "3", Make = "Toyota", Model = "Celica"},
    new Car { Id = "4", Make = "Golf", Model = "GTI"}
};




// List der indeholder objekter af datatypen Car
List<Car> carList = new List<Car>();


// Tilføje Car objekter til list
carList.Add(car1);
carList.Add(car2);

// Loope igenne liste
foreach (Car car in carList)
{
    Console.WriteLine($"Car make: {car.Make}, Car model: {car.Model}");
}




public class Car
{
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}