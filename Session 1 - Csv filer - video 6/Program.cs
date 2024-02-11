//? Læse fra fil

// opsæt filplacering til fil der vil læses fra
string path = "c:\\Demo\\Contact.csv";

// FileReader (returnere et string array) opsættes, og gemmes i string array tempRead
string[] tempRead =  File.ReadAllLines(path);


// loope igennem tempRead og printe hver linje ud (uden overskrift Id;FirstName;LastName)
for (int i = 1; i < tempRead.Length; i++)
{
    string[] temp = tempRead[i].Split(';');  // ved hver iteration vil vil gerne splitte på ; (som gemmes i et nyt string array)

    Console.Write($"Id: {temp[0]}, First name: {temp[1]}\n");  // printer fra temp array 
}
