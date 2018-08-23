using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFlyable
    {
        int Altitude { get; set; }

        void Fly();
        void IncreaseAltitude(int desiredAltitude);
        void DecreaseAltitude(int desiredAltitude);
    }
}
