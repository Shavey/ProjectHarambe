using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;



    class Actor
    {
        //Property variables for class
        private int age = 0;
        private string name;
        private string gender;
        private string race;
        private string species;
        public enum actorType { Player, Enemy, Animal, Friendly, Neutral };
        private List<string> inventory = new List<string>();
        actorType type = actorType.Player;
        private int health;

        //Working Variables for class
        public Random rand = new Random(DateTime.Now.Millisecond);


        public Actor(string Name, string Gender, string Species, int type, int health) // Actor constructor method
        {
            this.name = Name;
            this.gender = Gender;
            this.race = Race;
            this.species = Species;
            this.type = Type;
            this.health = Health;
        }

        public string GenerateName() // Name Generator method
        {
            var firstnameList = new List<string>();  // Create a new list for first names
            var lastnameList = new List<string>();   // Create a new list for last names

            // Add names to the list
            firstnameList.Add("Dave");
            firstnameList.Add("Angel");
            firstnameList.Add("Randy");
            firstnameList.Add("Mike");
            firstnameList.Add("Mel");
            firstnameList.Add("Robert");
            firstnameList.Add("Kevin");

            lastnameList.Add("Navarro");
            lastnameList.Add("Cook");
            lastnameList.Add("Raine");
            lastnameList.Add("Morrison");
            lastnameList.Add("Ramsay");
            lastnameList.Add("Hollie");
            lastnameList.Add("McStaggen");



            //Get the amount of names in list, and choose a random name
            var firstName = rand.Next(firstnameList.Count);
            var name1 = firstnameList.ElementAt(firstName);

            //Get the amount of names in list, and choose a random name
            var lastName = rand.Next(lastnameList.Count);
            var name2 = lastnameList.ElementAt(lastName);
            name = (name1 + " " + name2);
            return name;
        }

        public int GenerateAge() // Age Generator Method
        {

            int v1 = rand.Next(40); // Working variables
            int v2 = rand.Next(40);
            int v3 = rand.Next(40);

            int average; // The average number 

            average = v1 + v2 + v3 / 3; // Get an average age from the 3 random numbers.
            return average;
        }
        public string GenerateGender()
        {
            int chooser = rand.Next(2); // Working variables
            string gender = null;

            if (chooser > 0)
            {
                gender = "Female";

            }
            else
            {
                gender = "Male";
            }
            return gender;

        }

        public string SpeciesGenerator()
        {
            string species;
            List<string> SpeciesList = new List<string>();

            SpeciesList.Add("Human");
            SpeciesList.Add("Android");
            SpeciesList.Add("Saurian");
            SpeciesList.Add("Grey");

            var chooser = rand.Next(SpeciesList.Count);
            chooser = species;
        return species;

        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {

                name = value;
            }
        }

        public string Gender
        {
            get
            {

                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }

        public string Species
        {
            get
            {
                return species;
            }

            set
            {
                species = value;
            }
        }

        public List<string> Inventory
        {
            get
            {
                return inventory;
            }

            set
            {
                inventory = value;
            }
        }

        internal actorType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }
    }


