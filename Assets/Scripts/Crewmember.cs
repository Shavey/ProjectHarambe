using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    public class Crewmember : Actor
    {
            
        
        // Enum list for crew ranks, defaults to cadet
        public enum rankList { Cadet, Petty_Officer, Chief_Petty_Officer, Midshipman, Leutenant, Captain };
        rankList type = rankList.Cadet;

        // Crewmember Stat-Variables.
        public int speed { get; set; }
        public int marksmanship { get; set; }
        public int melee { get; set; }
        public int social { get; set; }
        public int cooking { get; set; }
        public int science { get; set; }
        public int medical { get; set; }
        public int engineering { get; set; }
        public int crafting { get; set; }
        public int piloting { get; set; }
        public int hacking { get; set; }
        public int botany { get; set; }
        public int mining { get; set; }
        public string position { get; set; }
        public string speciality { get; set; }
        public string rank { get; set; }


    // Crewmember constructor method, with Actor class extensions
    public Crewmember(string Name, string Gender, string Species, int type, int Health, int rank, string position, string speciality)

            : base(Name, Gender, Species, type, Health)
        {
            
                    

        }


        public string SpecialtyGenerator()
        {
            var professionList = new List<string>(); // Create a list of professions for the generator to use
            int random = rand.Next(professionList.Count); // Random number generator for the choosing of a list member

            professionList.Add("marksmanship");
            professionList.Add("melee");
            professionList.Add("social");
            professionList.Add("cooking");
            professionList.Add("science");
            professionList.Add("medical");
            professionList.Add("engineering");
            professionList.Add("crafting");
            professionList.Add("piloting");
            professionList.Add("hacking");
            professionList.Add("botany");
            professionList.Add("mining");

            speciality = professionList.ElementAt(random); // Using the random number generator from above to pull an element from the list
            return speciality;
                       

        }
  }


