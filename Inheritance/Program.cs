using System;

namespace Inheritance
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var b1 = new Birds() {

                Species = "parot",
                Color = "red",
                Sex = "male",
                Legs = 2,
                CanFly = "yes",
                Wings = 2,
                Beak = "does have",
                LayEggs = "it does",

            };

            var lizard = new Reptiles() {

                Species = "ingunana",
                Color = "green",
                Sex = "female",
                Legs = 4,
                ChangeColor = "can not",
                Malt = "it does",
                ColdBlood = "it is",
                Posionus = "is not"

            };


            var myAnimals = new Animals[] { b1, lizard };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"The Animal is a {animal.Species}");
                Console.WriteLine($"The Animal is the color {animal.Color}");
                Console.WriteLine($"The Animal is a {animal.Sex}");
                Console.WriteLine($"The Animal has {animal.Legs} legs");
                Console.WriteLine("");

            }





            



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
