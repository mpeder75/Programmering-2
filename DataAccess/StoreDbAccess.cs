using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StoreDbAccess
    {
        StoreDbContext db;

        public StoreDbAccess()
        {
            db = new StoreDbContext();
        }

        public async Task<List<Store>> GetAsync()
        {
            return await db.Stores.ToListAsync();
        }
    }
}
