using Session_5___AsyncSql___DA;
using Session_5___AsyncSql___Models;


namespace Session_5___AsyncSql___BL
{
    public class PersonBL
    {
        PersonDA db;

        public PersonBL()
        {
            db = new PersonDA();    
        }

        // CRUD - GetAllAsync()
        public async Task<List<Person>> GetAllAsync()
        {
            return await db.GetAllAsync();
        }

        /*// CRUD - GetOneAsync()
        public Person GetOneAsync(int id)
        {
            if (id > 0 && id < int.MaxValue)
            {
                return db.GetOneAsync(id);
            }
            return new Person();
        }*/

        public async Task<List<Person>> GetOneAsync(string searchTerm)
        {
            return await db.GetOneAsync(searchTerm);
        }


        public async Task<Person> GetOneAsync(int id)
        {
            return await db.GetOneAsync(id);
        }


        // CRUD - CreateAsync()
        public async Task<bool> CreateAsync(Person person)
        {
            if (!string.IsNullOrEmpty(person.FirstName) && !string.IsNullOrEmpty(person.LastName))
            {
                if(person.FirstName.Length < 51 && person.LastName.Length < 51)
                {
                    return await db.CreateAsync(person);
                }
            }
            return false;
        }

        // CRUD - UpdateAsync()
        public async Task<bool> UpdateAsync(Person person)
        {

            if (ValidateModel(person))
            {
                return await db.UpdateAsync(person);
            }
            return false;
        }

        // CRUD - DeleteAsync()
        public async Task<bool> DeleteAsync(int id)
        {
            if (id > 0 && id < int.MaxValue)
            {
                await db.DeleteAsync(id);
                return true;
            }
            return false;
        }
        
        public int FindNextId() 
        {
           return db.FindNextId();
        }


        // Validering - ingen access specifier, så sættes den til private
        private bool ValidateModel(Person person)
        {
            if (person.FirstName != null && person.LastName != null)
            {
                if (person.FirstName.Length > 1 && person.FirstName.Length < 51)
                {
                    if (person.LastName.Length > 1 && person.LastName.Length < 51)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

