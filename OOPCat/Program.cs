using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungry;
        
           public Cat(string _name, string _color) //Constuctor
           {
             name = _name;
             color = _color;
             hungry = 0;
            Console.WriteLine($"The Cat '{name}' with {color} color has been created.");
           }
           // getters for class properties
           public string Name
           {
            get { return name; }
           }
           public double Hungry
           {
            get { return hungry; }
           }
           public string Color
           {
            get { return color; }
           }

           public void Sleep()
           {
            Console.WriteLine("The Cat is sleeping.");
            hungry += 0.2; //happiness = happiness + 0.2
           }
          public void Meow()
          {
            Console.WriteLine("Meow-meow!");
          }
        
        }



       static void Main(string[] args)
       {
         Cat myCat = new Cat("Cat","Gray");        
         while (myCat.Hungry != 1)
         {
            myCat.Sleep();
         }
         myCat.Meow();               
         Console.WriteLine($"Name: {myCat.Name}");
         Console.WriteLine($"Color: {myCat.Color}");
         Console.WriteLine($"Level Of hunger: {myCat.Hungry}");

       }
    }
}
