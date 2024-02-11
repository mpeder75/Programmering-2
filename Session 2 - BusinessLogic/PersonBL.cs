using Aflevering_1___DataAccess;
using Aflevering_1___Models;

namespace Aflevering_1___BusinessLogic
{
    public class PersonBL
    {

        PersonDA dA;

        public PersonBL()
        {
            dA = new PersonDA();
        }


        public bool Create(Person person)
        {
            if (person == null)
            {
                return false;
            }
            else
            {
                return dA.Create(person);
            }
        }


        public List<Person> SortedFirstName()
        {
            return dA.SortedFirstName();
        }

        public int GetSmallestId()
        {
            return dA.GetSmallestId();
        }

        public int BornBefore()
        {
            return dA.BornBefore();
        }

        public List<Person> FindAdultPersons()
        {
            return dA.FindAdultPersons();
        }

    }
}
