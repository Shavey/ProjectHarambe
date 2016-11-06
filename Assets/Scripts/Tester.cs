
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class Program
    {

        static void Main(string[] args)
        {
            string keypress = null;
            keypress = Console.ReadLine();

            while (keypress != null)
            {

                var newActor = new Crewmember("Dave", "Male", "Human", 0, 100, "Ensign", "Operations", "Cooking");
                newActor.Age = newActor.GenerateAge();
                newActor.Name = newActor.GenerateName();
                newActor.Gender = newActor.GenerateGender();
                Console.WriteLine("The age is " + newActor.Age);
                Console.WriteLine("The name is " + newActor.Name);
                Console.WriteLine("The Gender is " + newActor.Gender);
                Console.WriteLine("The Rank is " + newActor.Rank);
                Console.WriteLine("The Position is " + newActor.Position);
                Console.WriteLine("The Specialty is " + newActor.Speciality);


                Console.ReadLine();
            }

        }
    }

