namespace Session_1___Models_video_5___Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BDate { get; set; }

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
            DateTime dd = DateTime.Now;

            int calcAge = 0;

            if (BDate.Year > 1900)
            {
                calcAge = dd.Year - BDate.Year;

                if (BDate.Month > dd.Month)
                {
                    calcAge--;
                }
                else if (BDate.Month == dd.Month)
                {
                    if (BDate.Day > dd.Day)
                    {
                        calcAge--;
                    }
                }
            }
            return calcAge;
        }

        public override string ToString()
        {
            return $"Contact has id: {Id}, First name is: {FirstName}, Last name is: {LastName}";
        }
    }
}
