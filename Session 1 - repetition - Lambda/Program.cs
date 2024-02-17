// todo Lambda

// initialize en List<Person> OG tilføj objekter til list på EN gang
List<Person> persons = new List<Person>
{
    new Person {Name = "John", Age = 25},
    new Person {Name = "Mary", Age = 32},
    new Person {Name = "Bob", Age = 10}
};


// sortere Liste efter alder med lambda
var sortedByAge = persons.OrderBy(person => person.Age);

foreach (var person in sortedByAge)
{
    Console.WriteLine($"{person.Name}, {person.Age}");
}

// sorter liste asc på fornavn
var sortedByName = persons.OrderBy(person => person.Name);  

foreach(var person in sortedByName)
{
    Console.WriteLine($"Sorted by name: {person.Name}, {person.Age}");
}


/*
    person repræsentere den Person man iterere over

    Lambda skal læses: (person => sortedByAge.Age);

    Tag alle person i sortedByAge og sorter dem på deres alder attribut

    ELLER

    people.OrderBy(person => person.Age);

    people orderby each person by person.age 
 
 */



class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}