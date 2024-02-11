
using Session_1___Models_video_1___Properties.DataAccess;
using Session_1___Models_video_1___Properties.Models;

//? -------- Contact.cs ----------/

// instans a Contact objekt "abe" initializeres
Contact abe = new Contact() { Id = 10, FirstName = "Abe", LastName = "Simpson" };

// printe FirstName
Console.WriteLine(abe.FirstName);

// printe alle attributter ud med ToString()
Console.WriteLine(abe.ToString());


//? -------- ContactDbAccess.cs ----------/

// instans a ContactDbAccess
ContactDbAccess db = new ContactDbAccess();

// CRUD GetAll() testes
List<Contact> contacts = db.GetAll();

contacts.ForEach(contact => Console.WriteLine($"Get All() printing:\nId: {contact.Id}\nFirst name: {contact.FirstName}\nLast name: {contact.LastName}"));


// CRUD GetOne() testes
Contact homer = db.GetOne(1);

Console.WriteLine($"GetOne() printing: Id = {homer.Id}, First name = {homer.FirstName}, Last name = {homer.LastName}");

// CRUD Create() testes
Contact lenny = new Contact() { Id = 12, FirstName = "Lenny", LastName = "Lenoard" };

bool isCreated = db.Create(lenny);

Console.WriteLine(isCreated);

// CRUD Update() testes

lenny.FirstName = "Ned";
lenny.LastName = "Flanders";

bool isUpdated = db.Update(lenny);

Console.WriteLine(lenny.ToString());

// CRUD Delete()

bool isDeleted = db.Delete(1);
Console.WriteLine($"Is object deleted?: {isDeleted}");

// FindNetxId testes
Contact ralph = new Contact() { Id = 9, FirstName = "Ralph", LastName = "Wiggum" };

db.Create(ralph);

Console.WriteLine();
