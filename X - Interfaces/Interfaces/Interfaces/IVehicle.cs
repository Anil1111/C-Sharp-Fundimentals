﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVehicle
    {
        int Speed { get; set; }

        void Move();
        void Accelerate(int desiredSpeed);
        void Decelerate(int desiredSpeed);
    }
}
