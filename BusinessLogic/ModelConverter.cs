using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // Modelconverter konvertere EntitityModel til en UiModel
    internal class ModelConverter
    {
        /* public UiModels.Store ConvertFromStoreEntity(EntityModels.Store storeEntity)
         {
             UiModels.Store storeUI = new UiModels.Store { Name = storeEntity.Name, Id = storeEntity.Id };

             return storeUI;
         }*/

        public UiModels.Store ConvertFromStoreEntity(EntityModels.Store storeEntity)
        {
            UiModels.Store storeUI = new UiModels.Store
            {
                Name = storeEntity.Name,
                Id = storeEntity.Id,
                Books = storeEntity.Books.Select(ConvertFromBookEntity).ToList()
            };
            return storeUI;
        }

        public UiModels.Book ConvertFromBookEntity(EntityModels.Book bookEntity)
        {
            UiModels.Book bookUI = new UiModels.Book
            {
                Title = bookEntity.Title,
                Id = bookEntity.Id,
                PublishDate = bookEntity.PublishDate,
                Author = ConvertFromAuthorEntity(bookEntity.Author)
            };
            return bookUI;
        }

        public UiModels.Author ConvertFromAuthorEntity(EntityModels.Author authorEntity)
        {
            UiModels.Author authorUI = new UiModels.Author
            {
                FirstName = authorEntity.FirstName,
                LastName = authorEntity.LastName,
                Id = authorEntity.Id
            };
            return authorUI;
        }
    }
}
