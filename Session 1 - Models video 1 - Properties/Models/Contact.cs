namespace Session_1___Models_video_1___Properties.Models
{
    // Når projekt bruger class libraies, skal class være public så de kan tilgå Contact
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        // ToString metode, så man kan printe objekt fra program.cs
        public override string ToString()
        {
            return $"Contact has id: {Id}, First name is: {FirstName}, Last name is: {LastName}";
        }
        

    }
}
