// Car objekter istancieres - Object initializer syntax
Car car1 = new Car() { Id = "1", Make = "BMW", Model = "M3" };
Car car2 = new Car() { Id = "2", Make = "Audi", Model = "A4" };

// Car objekter istancieres - Collection initializer syntax
List<Car> myList = new List<Car>()
{
    new Car { Id = "3", Make = "Toyota", Model = "Celica"},
    new Car { Id = "4", Make = "Golf", Model = "GTI"}
};



// Dictionary<TKey, TValue>
// * TKey er noget der unikt identificere data - eksemplet er det int Id der er unik -> TKey 
// * TValue er datatype den skal indeholde
Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();


// Tilføje til Dictonary
myDictionary.Add("1", car1);
myDictionary.Add("2", car2);


// loope gennem Dictionary
foreach (var (key, car) in myDictionary)
{
    Console.WriteLine($"Id: {key}, Make: {car.Make}, Model: {car.Model}");
}



public class Car
{
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}