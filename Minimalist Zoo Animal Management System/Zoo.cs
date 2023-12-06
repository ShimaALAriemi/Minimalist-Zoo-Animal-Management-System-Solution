using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimalist_Zoo_Animal_Management_System
{
    public class Zoo
    {
        private static List<Mammal> mammal = new List<Mammal>();
        private static List<Reptile> reptiles = new List<Reptile>();
        private static List<Bird> birds = new List<Bird>();


        public void Add(Mammal mal) 
        { 
            mammal.Add(mal);
            Console.WriteLine("\nAnimal Added Successfully!");
        }
        public void Add(Reptile rep) 
        {
            reptiles.Add(rep);
            Console.WriteLine("\nAnimal Added Successfully!");
        }
        public void Add(Bird bir)
        {
            birds.Add(bir);
            Console.WriteLine("\nAnimal Added Successfully!");
        }

            public void displayAnimals()
        {
            foreach (Mammal m in mammal) if(mammal != null) Console.WriteLine(m.Display());
            foreach (Reptile r in reptiles) if (reptiles != null) Console.WriteLine(r.Display());
            foreach (Bird b in birds) if (birds != null) Console.WriteLine(b.Display());


        }

        public void ObserveAnimalActions()
        {
            foreach (Mammal m in mammal) if (mammal != null) 
                {
                    m.Make_Sound(); m.Move(); m.Run();
                    Console.WriteLine();
                }

            foreach (Reptile r in reptiles) if (reptiles != null) 
                {
                    r.Make_Sound(); r.Move();
                    r.Swim();
                    Console.WriteLine( r.Poisonous());
                }
            foreach (Bird b in birds) if (birds != null)
                {
                  b.Make_Sound(); b.Move();
                    Console.WriteLine( b.Fly());

                }
        }




    }
}
