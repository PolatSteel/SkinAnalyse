using BusinessLayer.TestServiceForApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TestManagerForApi
{
    public class TestManager : ITestService
    {
        private static List<string> Liste = new List<string>();
        public List<string> AddToList(string value)
        {    
            Liste.Add(value);
            return Liste;
        }

        public List<string> GetAll()
        {
            return Liste;
        }
    }
}
