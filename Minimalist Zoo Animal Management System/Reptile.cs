
namespace Minimalist_Zoo_Animal_Management_System
{
    public class Reptile : Animal
    {
        public bool IsPoisonous { get; set; }
        public Reptile(string name, int age, string species, int dietType, bool IsPoisonous) : base(name, age, species, dietType)
        {
            this.Name = name;
        }

        public void Swim() => Console.Write($"{this.Name} is Swimming");
        public string Poisonous() => (IsPoisonous) ? $"{this.Name} is Poisonous" : $"{this.Name} isn't Poisonous";

        public override string Display() => base.Display() + $", Poisonous: "  + Poisonous();



    }

}
