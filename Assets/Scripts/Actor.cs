using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;



    public class Actor
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

        int x;
        int y;

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

        public string GenerateName(string gender) // Name Generator method
        {
            var malefirstnameList = new List<string>();  // Create a new list for first names
            var lastnameList = new List<string>();   // Create a new list for last names
            var femalefirstnameList = new List<string>();  // Create a new list for female first names
                                                     // Add names to the list
            malefirstnameList.Add("Dave");
            malefirstnameList.Add("Brian");
            malefirstnameList.Add("Joseph");
            malefirstnameList.Add("Bradley");
            malefirstnameList.Add("Jeff");
            malefirstnameList.Add("Rick");
            malefirstnameList.Add("Donald");
            malefirstnameList.Add("Chad");
            malefirstnameList.Add("Randy");
            malefirstnameList.Add("Mike");
            malefirstnameList.Add("Mel");
            malefirstnameList.Add("Robert");
            malefirstnameList.Add("Kevin");

            femalefirstnameList.Add("Sharon");
            femalefirstnameList.Add("Angel");
            femalefirstnameList.Add("Lois");
            femalefirstnameList.Add("Cara");
            femalefirstnameList.Add("Melisa");
            femalefirstnameList.Add("Amy");
            femalefirstnameList.Add("Jackie");
            femalefirstnameList.Add("Sarah");

            lastnameList.Add("Navarro");
            lastnameList.Add("Cook");
            lastnameList.Add("Raine");
            lastnameList.Add("Morrison");
            lastnameList.Add("Ramsay");
            lastnameList.Add("Hollie");
            lastnameList.Add("McStaggen");

        if (gender == "male")
        {

            var malefirstName = rand.Next(malefirstnameList.Count);
            var name11 = malefirstnameList.ElementAt(malefirstName);

            //Get the amount of names in list, and choose a random name
            var malelastName = rand.Next(lastnameList.Count);
            var name22 = lastnameList.ElementAt(malelastName);
            name = (name11 + " " + name22);
            return name;
        }
        else
        {
            //Get the amount of names in list, and choose a random name
            var firstName = rand.Next(femalefirstnameList.Count);
            var name1 = femalefirstnameList.ElementAt(firstName);

            //Get the amount of names in list, and choose a random name
            var lastName = rand.Next(lastnameList.Count);
            var name2 = lastnameList.ElementAt(lastName);
            name = (name1 + " " + name2);
            return name;
        }
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
            species = SpeciesList.ElementAt(chooser);
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

    public int X
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }

        set
        {
            y = value;
        }
    }
}


