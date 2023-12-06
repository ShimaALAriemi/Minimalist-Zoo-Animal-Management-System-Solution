

using System.Threading.Channels;

namespace Minimalist_Zoo_Animal_Management_System
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public DietType dietType { get; set; }

        public Animal(string name, int age, string species , int dietType)
        {
            this.Name = name;
            this.Age = age;
            this.Species = species;
            this.dietType = (DietType)dietType;
        }

        public void Make_Sound() => Console.Write($"{this.Name} is make_sound  ");
        public void Move() => Console.Write($"{this.Name} is Move  ");

        public virtual string Display() => $"Animal: {this.Name}, Age: {this.Age}, Species: {this.Species}, Diet: {this.dietType}";

    }
}
