using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimalist_Zoo_Animal_Management_System
{
    public class Mammal : Animal
    {
        public string Size { get; set; }
        public bool HasHair { get; set; }

        public Mammal(string Size, bool HasHair,string name, int age, string species, int dietType) : base(name, age, species, dietType)
        {
            this.Size = Size;
            this.HasHair = HasHair;

        }
        public void Run() => Console.Write($"{this.Name} is Running");
        public override string Display() => base.Display() + $", Size: {this.Size} ";


    }
}
