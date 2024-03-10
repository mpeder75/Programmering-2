using Session_4___BL;
using Session_4___Models;

PersonBL bl = new PersonBL();

Person homer = await bl.GetOneAsync(1);

Person abe = new Person() { Id = 10, FirstName = "Abe", LastName = "Simpson" };

bool isCreated = await bl.CreateAsync(abe);

List<Person> listPersons = await bl.GetAllAsync();

Console.WriteLine();

foreach (var person in listPersons)
{
    Console.WriteLine($"{person.Id} : {person.FirstName} : {person.LastName}\n");
}
