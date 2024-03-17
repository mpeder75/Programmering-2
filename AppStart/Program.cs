using DataAccess;
using EntityModels;
using System.Data;

StoreDbAccess db = new StoreDbAccess();

Store store = new Store() { Name = "Springfield" };

Book book = new Book() { Title = "My life", PublishDate= new DateTime(2022,2, 22)};

Author author = new Author() { FirstName = "Homer", LastName = "WSimpson" };

book.Author = author;
store.Books.Add(book);
db.Stores.Add(store);
await db.SaveChangesAsync();
