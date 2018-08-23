using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGenericsInterfaces
{
    public abstract class Model : IModel
    {
        public int Id { get; set; }

        public abstract void Print();
    }
}
