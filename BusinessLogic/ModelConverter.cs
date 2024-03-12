using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class ModelConverter
    {

        public UiModels.Store ConvertFromStoreEntity(EntityModels.Store storeEntity)
        {
            UiModels.Store storeUI = new UiModels.Store { Name = storeEntity.Name, Id = storeEntity.Id };

            return storeUI;
        }
    }
}
