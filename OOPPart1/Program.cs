using System;

namespace OOPPart1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;
            public Dog(string _name, int _spots) //Constuctor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created.");
            }
            // getters for class properties
            public string Name
            {
                get { return name; }

            }
            public double Happiness
            {
                get { return happiness; }

            }
            public int Spots
            {
                get { return spots; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2; //happiness = happiness + 0.2
            }
            public void WagTail()
            {
                Console.WriteLine("The dog is waging it's tail.");
            }
            public void Rename(string newName)
            {
                name = newName;
            }
        }



        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer", 15);
            //myDog.happiness = 10;
            //myDog.name = "Dog";
            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.WagTail();
            Console.WriteLine("Please enter an new name to rename your dog:");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Level Of happiness: {myDog.Happiness}");

        }
    }
}
