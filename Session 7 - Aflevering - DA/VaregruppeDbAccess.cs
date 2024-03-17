using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Session_7___Aflevering___Models;

namespace Session_7___Aflevering___DA
{
    public class VaregruppeDbAccess
    {
        VaregruppeDbContext db;

        public VaregruppeDbAccess()
        {
            db = new VaregruppeDbContext();
        }

        // CRUD - Get alle vare
        public async Task<List<Vare>> GetAllVareAsync()
        {
            return await db.Varer.ToListAsync();
        }

        // CRUD - Get alle varegrupper
        public async Task<List<Varegruppe>> GetAllVareGrupperAsync()
        {
            return await db.Varegrupper.ToListAsync();
        }

        // CRUD - Get EN vare
        public async Task<Vare> GetOneVareAsync(int id)
        {
            return await db.Varer.FindAsync(id);
        }

        // CRUD - Get EN varegruppe
        public async Task<Varegruppe> GetOneVaregruppeAsync(int id)
        {
            return await db.Varegrupper.FindAsync(id);
        }

        // CRUD - Create Varegruppe
        public async Task<bool> CreateVaregruppeAsync(Varegruppe varegruppe)
        {
            try
            {
                db.Varegrupper.Add(varegruppe);
                await db.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException e)
            {
                throw new ArgumentException("Error saving changes", e.Message);
            }
        }

        // CRUD - Create Varer
        public async Task<bool> CreateVareAsync(Vare vare)
        {
            try
            {
                db.Varer.Add(vare);
                await db.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException e)
            {
                throw new ArgumentException("Error saving changes", e.Message);
            }
        }

        // Crud - Delete Varer
        public async Task<bool> DeleteVareAsync(int id)
        {
            try
            {
                var toDelete = await db.Varer.FindAsync(id);

                if (toDelete != null)
                {
                    db.Varer.Remove(toDelete);
                    await db.SaveChangesAsync();
                }
                return true;
            }
            catch (DbUpdateException e)
            {
                throw new ArgumentException("Error saving changes", e.Message);
            }
        }

        // CRUD - Delete Varegruppe
        public async Task<bool> DeleteVaregruppeAsync(int id)
        {
            try
            {
                var toDelete = await db.Varegrupper.FindAsync(id);

                if (toDelete != null)
                {
                    db.Varegrupper.Remove(toDelete);
                    await db.SaveChangesAsync();
                }
                return true;
            }
            catch (DbUpdateException e)
            {
                throw new ArgumentException("Error saving changes", e.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Varegruppe", e);
            }
        }

        // CRUD - Update vare
        public async Task<bool> UpdateVareAsync(Vare vare)
        {
            // find vare objekt med samme id som parameter vare
            var vareToUpdate = await db.Varer.FindAsync(vare.Id);

            if (vareToUpdate != null)
            {
                vareToUpdate.Name = vare.Name;
                vareToUpdate.Description = vare.Description;
                vareToUpdate.StockAmount = vare.StockAmount;
                vareToUpdate.Price = vare.Price;

                await db.SaveChangesAsync();

                return true;
            }
            return false;
        }

        // CRUD - Update varegruppe
        public async Task<bool> UpdateVaregruppeAsync(Varegruppe varegruppe)
        {
            var varegruppeToUpdate = await db.Varegrupper.FindAsync(varegruppe.Id);

            if (varegruppeToUpdate != null)
            {
                varegruppeToUpdate.Name = varegruppe.Name;
                varegruppeToUpdate.Description  = varegruppe.Description;

                await db.SaveChangesAsync();

                return true;               
            }
            return false;
        }
    }
}

