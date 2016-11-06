using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    class Crewmember : Actor
    {
        // Member variables.
        string rank;
        string position;
        int experience;
        string speciality;

        // Crewmember Stat-Variables.
        int speed;
        int marksmanship;
        int melee;
        int social;
        int cooking;
        int science;
        int medical;
        int engineering;
        int crafting;
        int piloting;
        int hacking;
        int botany;
        int mining;



        public Crewmember(string Name, string Gender, string Species, int type, int Health, string rank, string position, string speciality)

            : base(Name, Gender, Species, type, Health)
        {
            this.Rank = rank;
            this.Position = position;
            this.Speciality = speciality;

        }


        public string SpecialtyGenerator()
        {
            var professionList = new List<string>();
            int random = rand.Next(professionList.Count);
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

            speciality = professionList.ElementAt(random);
            return speciality;


            {

            }

        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int Marksmanship
        {
            get
            {
                return marksmanship;
            }

            set
            {
                marksmanship = value;
            }
        }

        public int Melee
        {
            get
            {
                return melee;
            }

            set
            {
                melee = value;
            }
        }

        public int Social
        {
            get
            {
                return social;
            }

            set
            {
                social = value;
            }
        }

        public int Cooking
        {
            get
            {
                return cooking;
            }

            set
            {
                cooking = value;
            }
        }

        public int Science
        {
            get
            {
                return science;
            }

            set
            {
                science = value;
            }
        }

        public int Medical
        {
            get
            {
                return medical;
            }

            set
            {
                medical = value;
            }
        }

        public int Engineering
        {
            get
            {
                return engineering;
            }

            set
            {
                engineering = value;
            }
        }

        public int Crafting
        {
            get
            {
                return crafting;
            }

            set
            {
                crafting = value;
            }
        }

        public int Piloting
        {
            get
            {
                return piloting;
            }

            set
            {
                piloting = value;
            }
        }

        public int Hacking
        {
            get
            {
                return hacking;
            }

            set
            {
                hacking = value;
            }
        }

        public int Botany
        {
            get
            {
                return botany;
            }

            set
            {
                botany = value;
            }
        }

        public int Mining
        {
            get
            {
                return mining;
            }

            set
            {
                mining = value;
            }
        }

        public string Speciality
        {
            get
            {
                return speciality;
            }

            set
            {
                speciality = value;
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public string Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
     }
}


