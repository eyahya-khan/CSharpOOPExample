using System;
using System.IO;

namespace CSharpOOP
{
    //create class
    /*class Car
    {
      string color = "red";

      static void Main(string[] args)
      {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
      }
    }*/

    //create multiple object
    /*class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }*/

    //PART-1 START
    //multiple class 1.programm.cs 2.prog2.cs
    //PART-1 related with PART-1 of prog2.cs
    /*class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }*/
    //PART-1 END

    //******** CONSTRUCTOR ********
    // Create a Car class
    /*class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }*/

    //Constructor with parameter
    /*class Car
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }*/

    //######## MODIFIER ########
    /*class Car
    {
        private string model = "Mustang"; //Private modifier

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }*/

    //PART-2 START
    //Public modifier related with prog2.cs

    /*class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }*/
    //PART-2 END

    //PART-3 START
    //Properties SET & GET related with prog2.cs
    /*class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }*/
    //PART-3 END
    //PART-4 START
    //Shorthand properties SET & GET
    /*class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }*/
    //PART-4 END

    //######## INHERITANCE ########
    /*
     class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
     */
    //######## POLYMORPHISM ########
    /*class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }*/

    //######## ABSTRACT ########
    // Abstract class
    /*abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.sleep();
        }
    }*/

    //######## INTERFACE ########
    // Interface
    /*interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
    }*/

    //MULTIPLE INTERFACE
    /*interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("There is text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("There is other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }*/

    //######## ENUM ########
    /*enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }*/

    //######## FILE ########
    //using System.IO;  // include the System.IO namespace at first
    /*class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }*/

    //######## EXCEPTION ########
    /*class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }*/




}
