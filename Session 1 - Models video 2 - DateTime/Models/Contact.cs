using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1___Models_video_2___DateTime.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BDate { get; set; }  // Fødselsdato property

        // fullprop implementeres (giver en ekstra privat variabel)
        private int age;

        // når bruger kalder Age, sendes det i CalcAge som beregner alder, og sætter private age property
        public int Age
        {
            get 
            {
                // calcAge er privat variabel
                age = CalcAge();
                return age;
            }          
        }


        int CalcAge()
        {
            DateTime dd = DateTime.Now;                // dd objekt oprettes så alder kan beregnes

            int calcAge = 0;                            

            if (BDate.Year > 1900)                     // alder må ikk være mere end 124 år gammel
            {
                calcAge = dd.Year - BDate.Year;        // variabel til beregning af calcAge

                if (BDate.Month > dd.Month)            // 1. Tester på måned (Har man fødselsdag i senere måned på året)
                {
                    calcAge--;                         // 1. Så reduceres alder med EN
                }
                else if (BDate.Month == dd.Month)      // 2. Har man fødslesdag i samme måned 
                {
                    if (BDate.Day > dd.Day)            // 2. men fødsselsdag på en senere dato
                    {
                        calcAge--;                     // 2. trækkes EN fra alder
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


