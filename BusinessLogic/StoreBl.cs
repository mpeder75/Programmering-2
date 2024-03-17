using DataAccess;
using UiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class StoreBl
    {
        ModelConverter modelConverter;
        StoreDbAccess db;

        public StoreBl()
        {
            modelConverter = new ModelConverter();
            db = new StoreDbAccess();
        }


        public async Task<List<UiModels.Store>> GetAsync()
        {
            List<Store> stores = new List<Store>();

            foreach(var item in await db.GetAsync())
            {
                stores.Add(modelConverter.ConvertFromStoreEntity(item));
            }
            return stores;
        }

        public async Task AddAsync(UiModels.Store storeUi)
        {
            // await db.AddAsync(modelConverter.ConvertToStoreEntity(storeUi));
        }

    }
}
