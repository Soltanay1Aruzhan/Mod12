using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class SportsCar : Car
    {
        public SportsCar(string model, int speed) : base(model, speed) { }

        public override void StartRace()
        {
            Console.WriteLine($"{Model} жарысты бастайды!");
            Move();
        }
        public override void OnRace()
        {
            Move();
        }
    }
}
