using Session_3___Aflevering___Forms___Models;

namespace Session_3___Aflevering___Forms___DA
{
    public class PersonDA
    {
        private List<Person> persons;

        public PersonDA()
        {
            persons = new List<Person>();
            AddData();
        }

        // Create
        public bool Create(Person person)
        {
            Thread.Sleep(5000);

            persons.Add(person);
            return true;
        }

        // GetAll
        public List<Person> GetAll() 
        {
            Thread.Sleep(5000);
            return persons;
        }

        // GetOne
        public Person GetOne(int id) 
        {
            Thread.Sleep(5000);

            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return new Person();
        }

        // Update
        public bool Update(Person person) 
        {
            Thread.Sleep(5000);

            foreach (var existingPerson in persons)
            {
                if(existingPerson.Id == person.Id)
                {
                    existingPerson.FirstName = person.FirstName;
                    existingPerson.LastName = person.LastName;
                    return true;
                }
            }
            return false;
        }

        // Delete
        public bool Delete(int id)
        {
            Thread.Sleep(5000);

            bool isDeleted = false;
            Person temp = new Person();

            foreach (var person in persons) 
            {           
                if (person.Id == id)
                {
                    temp = person;                    
                }
            }
            return persons.Remove(temp);
        }


        // FindNextId
        public int FindNextId()
        {
            int nextId = 0;
            foreach (var person in persons)
            {
                if(person.Id > nextId)
                {
                    nextId = person.Id;
                }
            }
            return nextId + 1;
        }


        void AddData()
        {
            persons.Add(new Person() {Id = 1, FirstName="Homer", LastName = "Simpson"});
            persons.Add(new Person() {Id = 2, FirstName="Marge", LastName = "Simpson"});
            persons.Add(new Person() {Id = 3, FirstName="Bart", LastName = "Simpson"});
            persons.Add(new Person() {Id = 4, FirstName="Lisa", LastName = "Simpson"});
            persons.Add(new Person() {Id = 5, FirstName="Maggie", LastName = "Simpson"});
            persons.Add(new Person() {Id = 6, FirstName="Peter", LastName = "Griffin"});
            persons.Add(new Person() {Id = 7, FirstName="Lois", LastName = "Griffin"});
            persons.Add(new Person() {Id = 8, FirstName="Chris", LastName = "Griffin"});
            persons.Add(new Person() {Id = 9, FirstName="Meg", LastName = "Griffin"});
            persons.Add(new Person() {Id = 10, FirstName="Stewie", LastName = "Griffin"});
        }
    }
}
