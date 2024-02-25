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

        // CRUD Create
        public bool Create(Person person)
        {
            db.Create(person);
            return true;
        }


        // CRUD GetALL
        public List<Person> GetAll()
        {
            return db.GetAll();
        }

        // CRUD GetOne
        public Person GetOne(int id)
        {
            if (db != null && id < 0)
            {
                return db.GetOne(id);
            }
            return new Person();
        }

        // CRUD Update
        public bool Update(Person person)
        {
            db.Update(person);
            return true;
        }

        // CRUD Delete
        public bool Delete(int id)
        {
            if(id > 0 && id < int.MaxValue)
            {                   
                db.Delete(id);
                return true;
            }
            return false;
        }

    }
}
