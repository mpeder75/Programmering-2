using Newtonsoft.Json;
using Session_9___Undervisning.Models;

// indlæse tekst fra data.json
string txt = await File.ReadAllTextAsync("person.json");
//Console.WriteLine(txt);

// --------------------------------------------------------------------------------------- //


//! Konvertere Person.json til et C# objekt
//  1. Oprett en Models mappe, med Persons.cs
//  2. Importer nuget Newtonsoft.Json ver. 13.0.3 

string personTxt = await File.ReadAllTextAsync("person.json");
Person person = JsonConvert.DeserializeObject<Person>(personTxt);
Console.WriteLine(personTxt);

// --------------------------------------------------------------------------------------- //


//! Konvertere PersonArray.json til C# objekt

string personArray = await File.ReadAllTextAsync("PersonArray.json");
List<Person> deserializedPersons = JsonConvert.DeserializeObject<List<Person>>(personArray);
Console.WriteLine(personArray);

// --------------------------------------------------------------------------------------- //

//! Ignorere data
/* Man påsætter [JsonIgnore] over property i sin Model, eks:
    
[JsonIgnore]
public string "LastName" { get; set; }

Nu bliver LastName ikke indlæst

*/

// --------------------------------------------------------------------------------------- //


//! Ignorere datatypen null
// Gøres ved at ignorere null, NÅR der konverteres fra json til C# objekt
// 
List<Person> personIgnoreNull = JsonConvert.DeserializeObject<List<Person>>
    (personArray, new JsonSerializerSettings
    {
        NullValueHandling = NullValueHandling.Ignore
    });

// ELLER med dataAnnotations i Models person.cs, hvor man skriver over alle properties

// [JsonProperty(NullValueHandling = NullValueHandling.Ignore)])
