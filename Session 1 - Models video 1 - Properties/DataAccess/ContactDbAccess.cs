
using Session_1___Models_video_1___Properties.Models;

namespace Session_1___Models_video_1___Properties.DataAccess
{
    public class ContactDbAccess
    {
        // List<Contact> contacts declares
        private List<Contact> contacts;

        public ContactDbAccess()
        {
            // List<Contact> contacts initializeres i constructor
            contacts = new List<Contact>();

            // Når en instans a ContactDbAccess initíalizeres oprettes den med en Liste med 5 contacts
            AddData();
        }

        //? Create()
        public bool Create(Contact contact)
        {
            if (ValidateModel(contact))
            {
                contact.Id = FindNextId();
                contacts.Add(contact);
                return true;
            }
            return false;
        }

        //? GetAll() - returner alle contacts
        public List<Contact> GetAll()
        {
            return contacts;
        }

        //?GetOne - returner EN element
        public Contact GetOne(int id)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return new Contact();
        }

        //? Update()
        public bool Update(Contact contact)
        {
            if (ValidateModel(contact))
            {
                foreach (var existingContact in contacts)
                {
                    if (existingContact.Id == contact.Id)
                    {
                        existingContact.FirstName = contact.FirstName;
                        existingContact.LastName = contact.LastName;
                        return true;
                    }
                }
            }
            return false;
        }

        //? Delete()
        public bool Delete(int id)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    contacts.Remove(contact);
                    return true;
                }
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

        //? FindNextId()
        int FindNextId()
        {
            int nextId = 0;
            foreach (var element in contacts)
            {
                if(element.Id > nextId)
                {
                    nextId = element.Id;
                    
                }
            }
            return nextId + 1;
        }


        void AddData()
        {
            contacts.Add(new Contact() { Id = 1, FirstName = "Homer", LastName = "Simpson" });
            contacts.Add(new Contact() { Id = 2, FirstName = "Marge", LastName = "Simpson" });
            contacts.Add(new Contact() { Id = 3, FirstName = "Bart", LastName = "Simpson" });
            contacts.Add(new Contact() { Id = 4, FirstName = "Lisa", LastName = "Simpson" });
            contacts.Add(new Contact() { Id = 5, FirstName = "Maggie", LastName = "Simpson" });
        }
    }
}

