using System;

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
    //Public modifier
    /*class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }*/
    //PART-2 END

}
