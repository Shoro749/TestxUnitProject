using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestxUnitProject
{
    internal class Repository : IRepository<int>
    {
        public Repository() 
        {
            
        }

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
