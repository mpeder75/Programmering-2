using Session_4___Models;

namespace Session_4___DA
{
    public class PersonDA
    {
        List<Person> persons;

        public PersonDA()
        {
            persons = new List<Person>();
            AddData();
        }

        // CRUD CreateAsync
        public async Task<bool> CreateAsync(Person person)
        {

            await Task.Delay(500);

            person.Id = FindNextId();

            persons.Add(person);
            return true;
        }

        // CRUD GetAllAsync
        public async Task<List<Person>> GetAllAsync()
        {
            await Task.Delay(500);
            return persons;
        }

        // CRUD GetOneAsync
        public async Task<Person> GetOneAsync(int id)
        {
            await Task.Delay(500);

            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return new Person();
        }

        // CRUD UpdateAsync
        public async Task<bool> UpdateAsync(Person updatedPerson)
        {
            await Task.Delay(500); // Simulate an asynchronous operation (e.g., updating data in a database)

            foreach (var person in persons)
            {
                if (person.Id == updatedPerson.Id)
                {
                    // Update the person's properties
                    person.FirstName = updatedPerson.FirstName;
                    person.LastName = updatedPerson.LastName;
                    return true; // Return true once the update is successful
                }
            }
            return false; // Return false if the person to update is not found
        }

        // CRUD DeleteAsync
        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Delay(500); // Simulate an asynchronous operation (e.g., deleting data from a database)

            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    persons.Remove(person);
                    return true; // Return true once the person is deleted
                }
            }
            return false; // Return false if the person to delete is not found
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
