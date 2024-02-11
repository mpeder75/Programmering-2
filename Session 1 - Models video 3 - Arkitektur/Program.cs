using Session_1___Models_video_3___Arkitektur.BusinessLogic;
using Session_1___Models_video_3___Arkitektur.Models;

// instans af ContactBL - så vi kan tilgå dents metoder
ContactBL bl = new ContactBL();


// instans a Contact objekt "abe" initializeres
Contact abe = new Contact() { Id = 10, FirstName = "Abe", LastName = "Simpson" };

// printe FirstName
Console.WriteLine(abe.FirstName);



//? -------- ContactDB.cs ----------/

// CRUD GetAll() testes
List<Contact> contacts = bl.GetAll();

contacts.ForEach(contact => Console.WriteLine($"Get All() printing:\nId: {contact.Id}\nFirst name: {contact.FirstName}\nLast name: {contact.LastName}"));


// CRUD GetOne() testes
Contact homer =bl.GetOne(1);

Console.WriteLine($"GetOne() printing: Id = {homer.Id}, First name = {homer.FirstName}, Last name = {homer.LastName}");


// CRUD Create() testes
Contact lenny = new Contact() { Id = 12, FirstName = "Lenny", LastName = "Lenoard" };

bool isCreated = bl.Create(lenny);

Console.WriteLine(isCreated);

// CRUD Update() testes
lenny.FirstName = "Ned";
lenny.LastName = "Flanders";

bool isUpdated = bl.Update(lenny);

Console.WriteLine(lenny.ToString());

// CRUD Delete()

bool isDeleted = bl.Delete(1);
Console.WriteLine($"Is object deleted?: {isDeleted}");

// FindNetxId testes
Contact ralph = new Contact() { Id = 9, FirstName = "Ralph", LastName = "Wiggum" };

bl.Create(ralph);


// Beregning af alder

Contact moe = new Contact() { Id = 10, BDate = new DateTime(1960, 10, 5), FirstName = "moe", LastName = "Szyslak" };

Console.WriteLine($"Person is : {moe.Age} years old");


// Test af opdateret Delete() - vi vil slette Maggie
bool isNowDeleted = bl.Delete(2);

Console.WriteLine();
