using Session_1___Models_video_5___BL;
using Session_1___Models_video_5___Models;

// instans af ContactBL - så vi kan tilgå dents metoder
ContactBL bl = new ContactBL();

// CRUD GetAll() testes
List<Contact> contacts = bl.GetAll();

// CRUD GetOne() testes
Contact homer = bl.GetOne(1);

// Contact objekt oprettes
Contact abe = new Contact() { Id = 10, FirstName = "Abe", LastName = "Simpson" };

// CRUD Create() testes
bool isCreated = bl.Create(abe);

Console.WriteLine();



