using Session_1___Models_video_2___DateTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1___Models_video_2___DateTime.DataAccess
{
    public class ContactDbAccess
    {
        private List<Contact> contacts;

        public ContactDbAccess()
        {
            contacts = new List<Contact>();
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

