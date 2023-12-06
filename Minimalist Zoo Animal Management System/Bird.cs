
namespace Minimalist_Zoo_Animal_Management_System
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; }
        public Bird(string name, int age, string species, int dietType , bool CanFly) : base(name, age, species, dietType)
        {
            this.CanFly = CanFly;
        }
        public string Fly() => (CanFly)? $"{this.Name} can Flying" : $"{this.Name} can't Flying";

        public override string Display() => base.Display() + ", " + Fly();
          
        
    }
}
