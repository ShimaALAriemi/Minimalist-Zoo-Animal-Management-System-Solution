using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Minimalist_Zoo_Animal_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Minimalist Zoo Animal Management System!");
            display_Request();

            int userWant;
            while (true)
            {
                do
                {
                    Console.WriteLine("\n1.Add More Animals\n" +
                        "2.Display Zoo Animals\n" +
                        "3.Observe Animal Actions\n" +
                        "4.Exit");
                    Console.Write("Enter Your choise:");
                } while (!int.TryParse(Console.ReadLine(), out userWant) && userWant != 4);

                if (userWant == 4) break;
                else if (userWant == 1) display_Request();
                else if (userWant == 2) display();
                else if (userWant == 3) ObserveAnimalActions();


            }
            Console.WriteLine("\nThank you for using the Minimalist Zoo Animal Management System!");

        }

        static void display_Request()
        {
            Zoo zoo = new Zoo();
            Console.WriteLine("\nAdd Animals to the Zoo:");


            int animalType;

            do
            {
                Console.Write("Select Animal Type (1. Mammal, 2. Bird, 3. Reptile):");

            } while (!int.TryParse(Console.ReadLine(), out animalType) && animalType > 0 && animalType < 4);

            string size= "";
             bool checkVal=true;

            


            Console.Write("Enter Animal Name:");
            string name = Console.ReadLine();

            int age;

            do
            {
                Console.Write("Enter Animal Age:");


            } while (!int.TryParse(Console.ReadLine(), out age) && age>=0);

            Console.Write("Enter Animal Species:");
            string animalSpecies = Console.ReadLine();

            int AnimalDietType;

            do
            {
                Console.Write("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore):");


            } while (!int.TryParse(Console.ReadLine(), out AnimalDietType) && age > 0 && AnimalDietType <4);

            if (animalType == 1) size = getMammalVal(out checkVal);
            if (animalType == 2) checkVal = getBairdVal();
            if (animalType == 3) checkVal = getReptileVal();

            if (animalType == 1) zoo.Add(new Mammal(size, checkVal, name, age, animalSpecies, AnimalDietType)); 
            if (animalType == 2) zoo.Add(new Bird(name, age, animalSpecies, AnimalDietType, checkVal));
            if (animalType == 3) zoo.Add(new Reptile(name, age, animalSpecies, AnimalDietType, checkVal));


        }

        public static string getMammalVal(out bool val)
        {

            Console.Write("What Animal Size:");
            string animalSize = Console.ReadLine();

            String hair;
            do
            {
                Console.Write("Does has Hair? (yes/no): ");
                hair = Console.ReadLine().ToLower().Trim();
                val = (hair == "yes" || hair == "y") ? true : false;
            } while (!(hair == "yes" || hair == "no" || hair == "n" || hair == "y"));



            return animalSize;
        }

        public static bool getBairdVal()
        {

            String fly;
            bool val;
            do
            {
                Console.Write("Does it Fly? (yes/no): ");
                fly = Console.ReadLine().ToLower().Trim();
                val = (fly == "yes" || fly == "y") ? true : false;
            } while (!(fly == "yes" || fly == "no" || fly == "n" || fly == "y"));
            return val;
        }

        public static bool getReptileVal()
        {

            String IsPoisonous;
            bool boy;
            do
            {
                Console.Write("Does it Poisonousing? (yes/no): ");
                IsPoisonous = Console.ReadLine().ToLower().Trim();
                boy = (IsPoisonous == "yes" || IsPoisonous == "y") ? true : false;
            } while (!(IsPoisonous == "IsPoisonous" || IsPoisonous == "no" || IsPoisonous == "n" || IsPoisonous == "y"));
            return boy;
        }

        public static void display()
        {
            Console.WriteLine("Display Zoo Animals:\r\n -------------------------");
            Zoo zoo = new Zoo();
            zoo.displayAnimals();
        }

        public static void ObserveAnimalActions()
        {
            Console.WriteLine("\nObserve Animal Actions:\n");
            Zoo zoo = new Zoo();
            zoo.ObserveAnimalActions();
        }
    }
}