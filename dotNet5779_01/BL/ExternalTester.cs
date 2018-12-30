using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ExternalTester
    {
        private readonly string id;
        private string lastName;
        private string firstName;
        private CarTypeEnum typeCarToTest;

        public ExternalTester(string id)
        {
            this.id = id;
        }

        public string Id => id;

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public CarTypeEnum TypeCarToTest { get => typeCarToTest; set => typeCarToTest = value; }
    }
}
