﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Bird : IFlyable
    {
        public int Altitude { get; set; }

        public void Fly()
        {
            Console.WriteLine("Bird starts flying");
        }

        public void IncreaseAltitude(int desiredAltitude)
        {
            if (desiredAltitude > Altitude)
            {
                Altitude = desiredAltitude;
            }
        }

        public void DecreaseAltitude(int desiredAltitude)
        {
            if (desiredAltitude < Altitude)
            {
                Altitude = desiredAltitude;
            }
        }
    }
}
