using Scientist.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientist.web.Adapters.Interfaces
{
     interface ITheoryAdapter
    {
        List<Theory> GetAllTheories();
        void AddTheory(Theory Theory);
        void DeleteTheory(int id);
    }
}
