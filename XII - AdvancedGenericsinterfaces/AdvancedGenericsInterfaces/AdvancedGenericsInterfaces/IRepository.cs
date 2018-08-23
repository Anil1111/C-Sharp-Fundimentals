using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGenericsInterfaces
{
    interface IRepository<TModel> where TModel : Model
    {
        void Add(TModel model);
        TModel GetById(int id);
        List<TModel> GetAll();
        void Update(TModel model);
        void Delete(int id);
    }
}
