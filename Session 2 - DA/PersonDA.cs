using Session_2___Models;

namespace Session_2___DA
{
    public class PersonDA
    {
        List<Person> persons;

        public PersonDA()
        {
            persons = new List<Person>();
            AddData();
        }

        // Opret metode der tager person som parameter, og tilføjer denne til Listen. Brug Lambda til at finde næste Id
        public bool Create(Person person)
        {
            person.Id = FindNextId();
            persons.Add(person);
            return true;
        }

        // metode finder højeste Id, og sætter nextId til det samme +1;
        int FindNextId()
        {
            int nextId = persons.Max(person => person.Id);
            return nextId + 1;
        }

        //returner alle personer sorteret på fornavn descending
        public List<Person> SortedFirstName()
        {
            var sortedFirstName = persons.OrderByDescending(person => person.FirstName).ToList();
            return sortedFirstName;
        }

        // returnere det mindste Id i Listen
        public int GetSmallestId()
        {
            var getSmallestId = persons.Min(person => person.Id);
            return getSmallestId;
        }

        // find ud af hvor mange der er født før år 2000(variabel)
        public int BornBefore()
        {
            int bornBefore = persons.Count(person => person.BDate.Year < 2000);
            return bornBefore;
        }

        // find alle personer hvis alder er over/lig med 18, men mindre end/lig 68 - Age bliver beregnet gennem CalcAge i Person
        public List<Person> FindAdultPersons()
        {
            var adultPersons = persons.FindAll(person => person.Age >= 18 && person.Age <= 68);

            return adultPersons;
        }


        void AddData()
        {
            persons.Add(new Person() { Id = 1, FirstName = "Homer", LastName = "Simpson", BDate = new DateTime(1956, 5, 12) });
            persons.Add(new Person() { Id = 2, FirstName = "Marge", LastName = "Simpson", BDate = new DateTime(1961, 10, 12) });
            persons.Add(new Person() { Id = 3, FirstName = "Bart", LastName = "Simpson", BDate = new DateTime(1979, 4, 1) });
            persons.Add(new Person() { Id = 4, FirstName = "Lisa", LastName = "Simpson", BDate = new DateTime(1981, 7, 10) });
            persons.Add(new Person() { Id = 5, FirstName = "Maggie", LastName = "Simpson", BDate = new DateTime(1986, 4, 8) });
            persons.Add(new Person() { Id = 6, FirstName = "Moe", LastName = "Szyslak", BDate = new DateTime(1950, 2, 8) });
            persons.Add(new Person() { Id = 7, FirstName = "Ralph", LastName = "Wiggum", BDate = new DateTime(1979, 2, 2) });
            persons.Add(new Person() { Id = 8, FirstName = "Lenny ", LastName = "Leonard", BDate = new DateTime(1955, 6, 2) });
            persons.Add(new Person() { Id = 9, FirstName = "Car", LastName = "Carlson ", BDate = new DateTime(1955, 9, 11) });
            persons.Add(new Person() { Id = 10, FirstName = "Milhouse", LastName = "Van Houten", BDate = new DateTime(1981, 12, 12) });
        }
    }

}

