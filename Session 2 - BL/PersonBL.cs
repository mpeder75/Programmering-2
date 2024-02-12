using Session_2___DA;
using Session_2___Models;

namespace Session_2___BL
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




