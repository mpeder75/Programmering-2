//? Læse fra fil

// opsæt filplacering til fil der vil læses fra
string path = "c:\\Demo\\Contact.csv";

// FileReader opsættes, og gemmes List<string> tempRead - Bemærk at "File.Re..." kræver en ToList() til sidst
List<string> tempRead = File.ReadAllLines(path).ToList();


List<Contact> contacts = new List<Contact>();

// loope igennem tempRead og printe hver linje ud (uden overskrift Id;FirstName;LastName)
for (int i = 1; i < tempRead.Count; i++)
{
    string[] temp = tempRead[i].Split(';');     // ved hver iteration vil vil gerne splitte på ; (som gemmes i et nyt string array)

    Contact newContact = new Contact();         // Contact objekt vi gemmer til

    if (!string.IsNullOrWhiteSpace(temp[0]))    // tester og første del af læsningen er Null eller tom
    {
        newContact.Id = int.Parse(temp[0]);     // hvis den ikke er det, så parses Id til csv temp[0] 
    }
    newContact.FirstName = temp[1];             // newContact.FirstName assignes værdien fra temp[1]
    newContact.LastName = temp[2];              // newContact.LastName assignes værdien fra temp[2]
    contacts.Add(newContact);                   // til sidst tilføjes newContact til List<Contact> contacts
}


//? Skrive til fil

// vi har en variabel til filen i forvejen, vi opsætter hvad skal tilføjes
tempRead.Add("6;Abe;Simpson");

// nu skrives til filen WriteAllLines har brug for: en sti/path til fil, og data der skal skrives
File.WriteAllLines(path, tempRead);






//? Skrive/Kopiere data til ny fil på ny placering

// ny filplacering data sdkal gemmes til
string path2 = "c:\\Demo\\newContact.csv";

// list<string> vi først gemmer til
List<string> ls = new List<string>();


// iterere igennem List<Contact> contacts, og gem dem i list<string> ls
for (int i = 0; i < contacts.Count; i++)
{
    if (i == 0)    // ved første iteration, skabes en overskrift i filen, samt første linje med data (Homer data)
    {
        ls.Add($"{nameof(Contact.Id)};{nameof(Contact.FirstName)};{nameof(Contact.LastName)}"); // nameof(Contact.Id) er blot Id til overskrift
        ls.Add($"{contacts[i].Id};{contacts[i].FirstName};{contacts[i].LastName}");
    }
    else           // derefter tilføjes resten af elementer fra List<Contact> contacts til List<string> ls
    {
        ls.Add($"{contacts[i].Id};{contacts[i].FirstName};{contacts[i].LastName}");
    }
}

// skriv data fra List<string> ls til .csv filen
File.WriteAllLines(path2, ls);

Console.WriteLine();





//? Opret Csv file/reader logik som Model
public class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
