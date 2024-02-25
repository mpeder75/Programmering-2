using Session_4___BL;
using Session_4___Models;

PersonBL bl = new PersonBL();

Person homer = bl.GetOneAsync(1);

Person abe = new Person() { Id = 10, FirstName = "Abe", LastName = "Simpson" };

bool isCreated = bl.CreateAsync(abe);

List<Person> listPersons = bl.GetAll();

Console.WriteLine();

foreach (var person in listPersons)
{
    Console.WriteLine($"{person.Id} : {person.FirstName} : {person.LastName}\n");
}
