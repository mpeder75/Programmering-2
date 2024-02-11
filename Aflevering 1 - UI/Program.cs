using Aflevering_1___BusinessLogic;
using Aflevering_1___Models;


// instans af BusinessLogic, så vi kan kalde metoder igennem BL til DA

PersonBL bl = new PersonBL();

// person objekt istancieres
Person bobTabor = new Person() { Id = 10, FirstName = "Bob", LastName = "Tabor", BDate = new DateTime(1968, 10, 12) };


// Test om Create virker
bool isSuccess = bl.Create(bobTabor);
Console.WriteLine($"Er Bob tilføjet gennem Create: {isSuccess}");


// Test om SortedFirstName virker
List<Person> sortedFirstName = bl.SortedFirstName();

sortedFirstName.ForEach(p => Console.WriteLine($"{p.Id}, {p.FirstName}, {p.LastName}, {p.BDate.ToShortDateString()}"));


// Test om GetSmallestId virker
int temp = bl.GetSmallestId();
Console.WriteLine($"Det mindste Id er: {temp}");


// Test om BornBefore virker
int bornBefore = bl.BornBefore();
Console.WriteLine($"Der er {bornBefore} der er født før år 2000");


// Test om FindAdultPersons virker
List<Person> result = bl.FindAdultPersons();

result.ForEach(p => Console.WriteLine($"Personer ml. 18 & 68: {p.Age}, {p.FirstName}, {p.LastName}"));