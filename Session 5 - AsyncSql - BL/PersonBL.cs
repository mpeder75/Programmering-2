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


        //? CRUD - GetAll()
        // Denne kalder DataAccess GetAll(), og returnere data derfra
        public List<Person> GetAll()
        {
            return db.GetAll();
        }

        //? CRUD - GetOne()
        public Person GetOne(int id)
        {
            if (id > 0 && id < int.MaxValue)
            {
                return db.GetOne(id);
            }
            return new Person();
        }

        //? CRUD - Create()
        public bool Create(Person person)
        {
            if (ValidateModel(person))
            {
                return db.Create(person);
            }
            return false;
        }


        //? CRUD - Update()
        public bool Update(Person person)
        {

            if (ValidateModel(person))
            {
                return db.Update(person);
            }
            return false;
        }


        //? CRUD - Delete()
        public bool Delete(int id)
        {
            if (id > 0 && id < int.MaxValue)
            {
                db.Delete(id);
                return true;
            }
            return false;
        }



        //? Validering - ingen access specifier, så sættes den til private
        bool ValidateModel(Person person)
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

