using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Runtime.InteropServices;

namespace YourNamespace
{
    public class Program
    {
        public static void Main()
        {
            var people = ReadPeopleFromJsonFile();


            //! --------- Generel søgning ---------
            // Få første element & print ud
            var firstPerson = people.FirstOrDefault();
            Console.WriteLine("First person: " + firstPerson.ToString());

            // Find sidste person
            var lastPerson = people.LastOrDefault();
            Console.WriteLine("Last person: " + lastPerson.ToString());

            // Find FØRSTE person hvis navn starter med A
            var firstNameStartsWithA = people.FirstOrDefault(p => p.FirstName.StartsWith("A"));
            Console.WriteLine(firstNameStartsWithA.ToString());

            // returner eneste person hvis Id er lig 50
            var getSinglePerson = people.SingleOrDefault(p => p.Id == 10004);
            Console.WriteLine($"Person with id 10004 = {getSinglePerson.ToString()}");



            //! --------- Max, Min, Avg ---------
            // Find max salary
            var getMaxSalary = people.Max(p => p.Salary);
            Console.WriteLine("Max salary = " + getMaxSalary.ToString());

            // Find Min salary
            var getMinSalary = people.Min(p => p.Salary);
            Console.WriteLine("Min salary = " + getMinSalary.ToString());

            // Find gennemsnitsløn
            var avgSalary = people.Average(p => p.Salary);
            Console.WriteLine("Average salary = " + avgSalary);



            //! --------- OrderBy ---------
            var sortedByAge = people.OrderBy(p => p.Birthday).ToList();
            sortedByAge.ForEach(p => Console.WriteLine(p.ToString()));




            //! Any
            if (people.Any())
            {
                Console.WriteLine("The collection have data");
            } else
            {
                Console.WriteLine("Collection is empty");
            }





            IEnumerable<int> collection
















        }



        //? Json reader method
        public static Person[] ReadPeopleFromJsonFile()
        {
            using (var reader = new StreamReader("people.json"))
            {
                string jsonDate = reader.ReadToEnd();
                var people = JsonConvert.DeserializeObject<Person[]>(jsonDate);
                return people;
            }
        }
    }

    //? Person class
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{Id} | {FirstName} | {LastName} | {City} | ${Salary} | {Birthday.ToShortDateString()}";
        }
       
    }
}
