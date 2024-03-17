// List a typen Cars, der har 
List<Car> myCars = new List<Car>
{
    new Car() {Id= "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2011},
    new Car() {Id= "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2004},
    new Car() {Id= "C3", Make = "BMW", Model = "745i", StickerPrice = 75000, Year = 2013},
    new Car() {Id= "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2002},
    new Car() {Id= "E5", Make = "BMW", Model = "745li", StickerPrice = 57000, Year = 2010}
};


// --------- LINQ med Lambda --------- //

// Find biler af typen "BMW" der har en price på mere end 35000
var bmws2 = myCars.Where(p => p.Make == "BMW" && p.StickerPrice >= 35000);

foreach (var item in myCars)
{
    Console.WriteLine($"Cars of type 'BMW' priced over 35000 -> {item.Id}, {item.Make}, {item.Model},{item.StickerPrice}");
}

// Sorter Liste efter Year
// orderByDescending sortere automatisk listen, blot indiker i Lambda det er Year den skal sorter på
var orderedListDecsc = myCars.OrderByDescending(car => car.Year);

foreach (var car in orderedListDecsc)
{
    Console.WriteLine($"List sorted by year: {car.Year} {car.Make},{car.Model}");
}



// -------------- BRUG flere Lambda sammen ----------------------
// Find det FØRSTE element i List HVOR Make = "BMW" og sorter desc 
var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");

Console.WriteLine($"First 'BMW' in List: {firstBMW.Id}, {firstBMW.Make}, {firstBMW.Model}");


// Bruge Lambda til bool validering af liste. Er alle biler efter 2010? 
Console.WriteLine(myCars.TrueForAll(p => p.Year > 2010));


// Loop gennem Liste med Foreach med lambda, og print til skørm
myCars.ForEach(p => Console.WriteLine($"{p.Id}, {p.Make}, {p.Model} {p.StickerPrice}"));


// Brug lambda til at trække 3000 fra alle biler  
myCars.ForEach(p => p.StickerPrice -= 3000);


// Findes der et Car objekt, hvor model er '745li' - returnere true/false
bool istrue = myCars.Exists(p => p.Model == "745li");
Console.WriteLine(istrue);

// Summer prisen på alle biler i Listen
Console.WriteLine("Totalal price for cars" + myCars.Sum(p => p.StickerPrice));



//? --------- LINQ som query --------- //

// Find KUN biler af typen "BMW"
var bmws = from car in myCars
           where car.Make == "BMW"
           select car;

foreach (var car in bmws)
{
    Console.WriteLine($"Cars of type 'BMW' -> {car.Id}, {car.Make},{car.Model}, {car.StickerPrice}, {car.Year}");
}

// Find biler af typen "BMW" der er produceret senere end 2010
var bmws1 = from car in myCars
            where car.Make == "BMW" && car.Year >= 2010
            select car;

foreach (Car item in bmws1)
{
    Console.WriteLine($"Cars of type 'BMW' produced after 2010 -> {item.Id}, {item.Make}, {item.Model},{item.Year}");
}

// sortere List efter year
var orderedCars = from car in myCars
                  orderby car.Year descending
                  select car;

foreach (var item in orderedCars)
{
    Console.WriteLine($"orderedCars sorted by year: {item.Year}, {item.Id}, {item.Make}, {item.Model}");
}

class Car
{
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int StickerPrice { get; set; }
    public double Year { get; set; }
}



