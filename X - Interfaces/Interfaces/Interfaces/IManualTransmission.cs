using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IManualTransmission
    {
        int Gear { get; set; }
        
        void ShiftGearUp();
        void ShiftGearDown();
    }
}
