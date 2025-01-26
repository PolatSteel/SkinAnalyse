using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TestServiceForApi
{
    public interface ITestService
    {
        public List<string> AddToList(string value);
        public List<string> GetAll();
    }
}
