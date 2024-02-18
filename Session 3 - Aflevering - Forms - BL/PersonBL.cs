using Session_3___Aflevering___Forms___DA;
using Session_3___Aflevering___Forms___Models;

namespace Session_3___Aflevering___Forms___BL
{
    public class PersonBL
    {
        PersonDA db;

        public PersonBL()
        {
            db = new PersonDA();
        }

        // Create
        public bool Create(Person person)
        {
            return db.Create(person);

        }

        // GetAll
        public List<Person> GetAll()
        {
            return db.GetAll();         
        }

        // GetOne
        public Person GetOne(int id) 
        {
            if(id > 0 && id < int.MaxValue)
            {
                return db.GetOne(id);
            }
            return new Person();
        }

        // Update
        public bool Update(Person person)
        {
            return db.Update(person);
        }

        // Delete
        public bool Delete(int id)
        {
            if (id > 0 && id < int.MaxValue)
            {
                db.Delete(id);
                return true;
            }
            return false;
        }

        //FindNextId
        public int FindNextId() 
        {
            return db.FindNextId();
        }
    }
}
