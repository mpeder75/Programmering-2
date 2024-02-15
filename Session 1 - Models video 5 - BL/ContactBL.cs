using Session_1___Models_video_5___DA;
using Session_1___Models_video_5___Models;

namespace Session_1___Models_video_5___BL
{
    public class ContactBL
    {
        // ref til DataAccess
        ContactDA db;

        public ContactBL()
        {
            // DataAccess db initialiseres i constructor
            db = new ContactDA();
        }

        //? CRUD - GetAll()
        // Denne kalder DataAccess GetAll(), og returnere data derfra
        public List<Contact> GetAll()
        {
            return db.GetAll();
        }

        //? CRUD - GetOne()
        public Contact GetOne(int id)
        {
            if (id > 0 && id < int.MaxValue)
            {
                return db.GetOne(id);
            }
            return new Contact();
        }

        //? CRUD - Create()
        public bool Create(Contact contact)
        {
            if (ValidateModel(contact))
            {
                return db.Create(contact);
            }
            return false;
        }


        //? CRUD - Update()
        public bool Update(Contact contact)
        {

            if (ValidateModel(contact))
            {
                return db.Update(contact);
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
        bool ValidateModel(Contact contact)
        {
            if (contact.FirstName != null && contact.LastName != null)
            {
                if (contact.FirstName.Length > 1 && contact.FirstName.Length < 51)
                {
                    if (contact.LastName.Length > 1 && contact.LastName.Length < 51)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

