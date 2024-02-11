using Session_1___Models_video_3___Arkitektur.Models;


namespace Session_1___Models_video_3___Arkitektur.DataAccess
{
    public class ContactDA
    {
        private List<Contact> contacts;

        public ContactDA()
        {
            contacts = new List<Contact>();
            AddData();
        }

        //? Create()
        public bool Create(Contact contact)
        {
            contact.Id = FindNextId();
            contacts.Add(contact);
            return true;
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

            foreach (var existingContact in contacts)
            {
                if (existingContact.Id == contact.Id)
                {
                    existingContact.FirstName = contact.FirstName;
                    existingContact.LastName = contact.LastName;
                    return true;
                }
            }
            return false;
        }


        //? Delete()
        public bool Delete(int id)
        {
            bool isDeleted = false;
            Contact temp = new Contact();

            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    temp = contact;
                }
            }
            return contacts.Remove(temp);
        }

        //? FindNextId()
        int FindNextId()
        {
            int nextId = 0;
            foreach (var element in contacts)
            {
                if (element.Id > nextId)
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




