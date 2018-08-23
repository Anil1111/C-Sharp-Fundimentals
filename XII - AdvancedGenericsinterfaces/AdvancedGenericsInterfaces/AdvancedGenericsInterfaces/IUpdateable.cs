using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGenericsInterfaces
{
    interface IUpdateable<TModel> where TModel : Model
    {
        void Update(TModel model);
    }
}
