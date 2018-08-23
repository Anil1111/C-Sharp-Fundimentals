using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Plane : IVehicle, IFlyable
    {
        public int Speed { get; set; }

        public int Altitude { get; set; }

        public void Move()
        {
            Console.WriteLine("plane starts moving");
        }

        public void Fly()
        {
            Console.WriteLine("Plane starts flying");
        }

        public void Accelerate(int desiredSpeed)
        {
            if (desiredSpeed > Speed)
            {
                Speed = desiredSpeed;
            }
        }

        public void Decelerate(int desiredSpeed)
        {
            if (Speed < desiredSpeed)
            {
                Speed = desiredSpeed;
            }
        }

        public void IncreaseAltitude(int desiredAltitude)
        {
            if (Altitude > desiredAltitude)
            {
                Altitude = desiredAltitude;
            }
        }

        public void DecreaseAltitude(int desiredAltitude)
        {
            if (Altitude < desiredAltitude)
            {
                Altitude = desiredAltitude;
            }
        }
    }
}
