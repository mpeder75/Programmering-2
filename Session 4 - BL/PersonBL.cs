using Session_4___DA;
using Session_4___Models;

namespace Session_4___BL
{
    public class PersonBL
    {

        PersonDA db;

        public PersonBL()
        {
            db = new PersonDA();
        }

        // CRUD CreateAsync
        public async Task<bool> CreateAsync(Person person)
        {
            if (person != null)
            {
                return await db.CreateAsync(person);
            }
            return false;
        }


        // CRUD GetALL
        public async Task<List<Person>> GetAllAsync()
        {
            return await db.GetAllAsync();
        }

        // CRUD GetOneAsync
        public async Task<Person> GetOneAsync(int id)
        {
            if (id >= 0)
            {
                return await db.GetOneAsync(id);
            }
            return new Person();
        }

        // CRUD UpdateAsync
        public async Task<bool> UpdateAsync(Person person)
        {
            if (person != null)
            {
                return await db.UpdateAsync(person);
            }
            return false;
           
        }

        // CRUD DeleteAsync
        public async Task<bool> DeleteAsync(int id)
        {
            if(id > 0 && id < int.MaxValue)
            {                   
                return await db.DeleteAsync(id);               
            }
            return false;
        }

    }
}
