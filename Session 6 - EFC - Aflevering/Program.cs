using Session_6___EFC___Aflevering.Data;
using Session_6___EFC___Aflevering.Models;
using System.Diagnostics;

// Instans af DbContext
VareDbContext db = new VareDbContext();


/*
// objekt oprettes
Vare pizza1 = new Vare()
{
    Name = "Magerita",
    Description = "Uden kød",
    Price = 55,
    InventoryStatus = 50
};
await db.Vares.AddAsync(pizza1);    // objekt tilføjes til dbSet<Vares> 
await db.SaveChangesAsync();        // som derefter persistes ned i databasen

Vare pizza2 = new Vare()
{
    Name = "Meat De Luze",
    Description = "Med kød",
    Price = 65,
    InventoryStatus = 15
};
await db.Vares.AddAsync(pizza2);
await db.SaveChangesAsync();

Vare sodavand1 = new Vare()
{
    Name = "Coca Cola",
    Description = "Regular coke",
    Price = 20,
    InventoryStatus = 15
};
await db.Vares.AddAsync(sodavand1);
await db.SaveChangesAsync();

Vare sodavand2 = new Vare()
{
    Name = "Pepsi",
    Description = "Regular Pepsi",
    Price = 19,
    InventoryStatus = 12
};
await db.Vares.AddAsync(sodavand2);
await db.SaveChangesAsync();

Vare kebab1 = new Vare()
{
    Name = "Kebab",
    Description = "Kebab med kød",
    Price = 49,
    InventoryStatus = 12
};
await db.Vares.AddAsync(kebab1);
await db.SaveChangesAsync();


Vare kebab2 = new Vare()
{
    Name = "Veggie Kebab",
    Description = "Veggie version",
    Price = 39,
    InventoryStatus = 18
};
await db.Vares.AddAsync(kebab2);
await db.SaveChangesAsync();


Vare grillMix1 = new Vare()
{
    Name = "Grillmix med kylling",
    Description = "Der er kylling i",
    Price = 69,
    InventoryStatus = 12
};
await db.Vares.AddAsync(grillMix1);
await db.SaveChangesAsync();


Vare grillMix2 = new Vare()
{
    Name = "Grillmix veggie",
    Description = "Veggie version",
    Price = 69,
    InventoryStatus = 12
};
await db.Vares.AddAsync(grillMix2);
await db.SaveChangesAsync();
*/


await PrintFirstLast();

bool IsDeleted = await DeleteVareAsync(2);



// Update
async Task<bool> UpdateAsync(Vare vare)
{
    var vareToUpdate = await db.Vares.FindAsync(vare.Id);

    if (vareToUpdate != null)
    {
        vareToUpdate.Id = vare.Id;
        vareToUpdate.Name = vare.Name;
        vareToUpdate.Description = vare.Description;
        vareToUpdate.Price = vare.Price;
        vareToUpdate.InventoryStatus = vare.InventoryStatus;
        db.Vares.Update(vareToUpdate);
        return true;
    } else
    {
        await Console.Out.WriteLineAsync("Could not find Vare");
        return false;
    }
}

// Delete
async Task<bool> DeleteVareAsync(int id)
{
    var vareToDelete = await db.Vares.FindAsync(id);

    if (vareToDelete != null)
    {
       db.Vares.Remove(vareToDelete);
       await db.SaveChangesAsync();
       return true;
    } else
    {
        await Console.Out.WriteLineAsync("Vare not found");
        return false;
    }    
}

// Print first/Last
async Task PrintFirstLast()
{
    var sortedDatabase = db.Vares.OrderByDescending(p => p.Id);

    var firstEntity = sortedDatabase.First();
    var lastEntity = sortedDatabase.Last();

    if(firstEntity != null && lastEntity != null)
    {
        Console.Out.WriteLineAsync(firstEntity.ToString());
        Console.Out.WriteLineAsync(lastEntity.ToString());
    } else
    {
        Console.Out.WriteLineAsync("First or Lastr entity not found");
    }       
}


