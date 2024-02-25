using Session_4___Models;

namespace Session_4___DA
{
    public class PersonDA
    {
        List<Person> persons;

        public PersonDA()
        {
            persons = new List<Person>();
        }

        // CRUD Create
        public bool Create(Person person)
        {
            person.Id = FindNextId();

            persons.Add(person);
            return true;
        }

        // CRUD GetAll
        public List<Person> GetAll()
        {
            return persons;
        }

        // CRUD GetOne
        public Person GetOne(int id)
        {
            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return new Person();
        }

        // CRUD Update
        public bool Update(Person person)
        {
            foreach (var item in persons)
            {
                if (item.Id == person.Id)
                {
                    person.Id = item.Id;
                    person.FirstName = item.FirstName;
                    person.LastName = item.LastName;
                }
                return true;
            }
            return false;
        }

        // CRUD Delete
        public bool Delete(int id)
        {
            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    persons.Remove(person);
                }
                return true;
            }
            return false;
        }






        int FindNextId()
        {
            int nextId = 0;
            foreach (var person in persons)
            {
                if (person.Id > nextId)
                {
                    nextId = person.Id;
                }
            }
            return nextId + 1;
        }

        void AddData()
        {
            persons.Add(new Person() { Id = 1, FirstName = "Homer", LastName = "Simpson" });
            persons.Add(new Person() { Id = 2, FirstName = "Marge", LastName = "Simpson" });
            persons.Add(new Person() { Id = 3, FirstName = "Bart", LastName = "Simpson" });
            persons.Add(new Person() { Id = 4, FirstName = "Lisa", LastName = "Simpson" });
            persons.Add(new Person() { Id = 5, FirstName = "Maggie", LastName = "Simpson" });
        }

    }
}
