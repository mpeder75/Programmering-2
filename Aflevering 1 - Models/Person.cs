namespace Aflevering_1___Models;
public class Person
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime BDate { get; set; }

    // fullprop på calcAge/Age
    private int age;

    public int Age
    {
        get
        {
            age = CalcAge();
            return age;
        }

    }

    int CalcAge()
    {
        // dags dato oprettes
        DateTime dd = DateTime.Now;

        int calcAge = 0;

        // validering
        if (BDate.Year > 1900)
        {
            calcAge = dd.Year - BDate.Year;

            if (BDate.Month > dd.Month)            // Month: hvis man først har fødselsdag i næste mnd
            {
                calcAge--;                          // reduceres calcAge
            }
            else if (BDate.Month == dd.Month)      // Month: hvis man har fødselsdag i samme måned
            {
                if (BDate.Day > dd.Day)            // Man man har fødsels senere på måneden
                {
                    calcAge--;                      // reduceres calcAge
                }
            }
        }
        return calcAge;
    }
}

