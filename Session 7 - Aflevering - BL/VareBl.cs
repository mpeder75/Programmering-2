using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session_7___Aflevering___DA;
using Session_7___Aflevering___Models;


namespace Session_7___Aflevering___BL
{
    public class VareBl
    {
        VaregruppeDbAccess db;
        ValidateVare validateVare;
        ValidateVaregruppe validateVaregruppe;

        public VareBl()
        {
            db = new VaregruppeDbAccess();
            validateVare = new ValidateVare();
            validateVaregruppe = new ValidateVaregruppe();
        }

        // CRUD - Get All vare
        public async Task<List<Vare>> GetAllVareAsync()
        {
            List<Vare> vare = new List<Vare>();

            foreach (var item in await db.GetAllVareAsync())
            {
                vare.Add(item);
            }
            return vare;
        }

        // CRUD - Get One vare
        public async Task<Vare> GetOneVareAsync(int id)
        {
            return await db.GetOneVareAsync(id);
        }

        // CRUD - Get All varegrupper
        public async Task<List<Varegruppe>> GetAllVaregrupperAsync()
        {
            return await db.GetAllVareGrupperAsync();
        }

        // CRUD - Get One Varegruppe
        public async Task<Varegruppe> GetOneVaregruppe(int id)
        {
            return await db.GetOneVaregruppeAsync(id);
        }


        // CRUD - Create varegruppe & vare på EN gang
        public async Task<bool> CreateVaregruppeAndVareAsync(Varegruppe varegruppe, Vare vare)
        {
            if (ValidateVareData(vare) && ValidateVaregruppeData(varegruppe))
            {
                await db.CreateVaregruppeAsync(varegruppe);

                await db.CreateVareAsync(vare);

                return true;
            }
            return false;
        }

        // CRUD - Create varegruppe
        public async Task<bool> CreateVaregruppe(Varegruppe varegruppe)
        {
            if (ValidateVaregruppeData(varegruppe))
            {
                await db.CreateVaregruppeAsync(varegruppe);

                return true;
            }
            return false;
        }


        // CRUD - Create vare
        public async Task<bool> CreateVareAsync(Vare vare)
        {
            if (ValidateVareData(vare))
            {
                await db.CreateVareAsync(vare);

                return true;
            }
            return false;
        }

        // CRUD - Delete vare
        public async Task<bool> DeleteVareAsync(int id)
        {
            if (await db.DeleteVareAsync(id))
            {
                return true;
            }
            return false;
        }

        // CRUD - Delete varegruppe
        public async Task<bool> DeleteVaregruppeAsync(int id)
        {
            try
            {
                await db.DeleteVaregruppeAsync(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating a vare: {ex.Message}");
                return false;
            }
        }


        public async Task<bool> UpdateVareAsync(Vare vare)
        {
            try
            {
                if (ValidateVareData(vare))
                {
                    await db.UpdateVareAsync(vare);                    
                }
                return true;
            }catch (DbUpdateException e) 
            {
                throw new DbUpdateException("Could not save changes");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating a vare: {ex.Message}");
                return false;
            }
        }


        // CRUD - Update varegruppe
        public async Task<bool> UpdateVaregruppeAsync(Varegruppe varegruppe)
        {
            try
            {
                if (ValidateVaregruppeData(varegruppe))
                {
                    await db.UpdateVaregruppeAsync(varegruppe);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while updating a varegruppe: {ex.Message}");
                return false;
            }
        }


        // ValidateVare
        public bool ValidateVareData(Vare vare)
        {
            if (validateVare.ValidateVareName(vare) && validateVare.ValidateVareStockAmount(vare) && validateVare.ValidateVarePrice(vare))
            {
                return true;
            }
            return false;
        }

        // ValidateVaregruppe
        public bool ValidateVaregruppeData(Varegruppe varegruppe)
        {
            if (validateVaregruppe.ValidateVaregruppeName(varegruppe) && validateVaregruppe.ValidateVaregruppeDescription(varegruppe))
            {
                return true;
            }
            return false;
        }
    }
}

