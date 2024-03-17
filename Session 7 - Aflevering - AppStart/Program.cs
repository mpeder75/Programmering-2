using Session_7___Aflevering___BL;
using Session_7___Aflevering___Models;

VareBl vareBl = new VareBl();

// opret varegruppe "Pizza"
var pizzaVaregruppe = new Varegruppe { Name = "Pizza" };
var sodavandVaregruppe = new Varegruppe { Name = "Sodavand" };

// opret vare
var margheritaPizza = new Vare { Name = "Margherita", Description = "Ost, tomat", StockAmount = 10, Price = 50, Varegruppe = pizzaVaregruppe };
var cocaCola = new Vare { Name = "Coca-Cola", Description = "Regular", StockAmount = 24, Price = 20, Varegruppe = sodavandVaregruppe };


// Create/persist med varegruppe 'pizza' & object 'margheritaPizza' 
await vareBl.CreateVaregruppeAndVareAsync(pizzaVaregruppe, margheritaPizza);

// Create/persist varegruppe
await vareBl.CreateVaregruppe(sodavandVaregruppe);

//Create/persist vare
await vareBl.CreateVareAsync(cocaCola);

// Get alle vare
var getAllVare = await vareBl.GetAllVareAsync();
getAllVare.ForEach(p => Console.WriteLine(p.ToString()));

// Hent alle varegrupper
var getAllVaregruppe = await vareBl.GetAllVaregrupperAsync();
getAllVare.ForEach(p => Console.WriteLine(p.ToString()));

// Hent vare hvis Navn starter med M og pris er >= 50
var getPizzaThatStartsWithM = getAllVare.Where(p => p.Name.StartsWith("M") && p.Price >= 50).ToList();
getPizzaThatStartsWithM.ForEach(p => Console.WriteLine(p.ToString()));



