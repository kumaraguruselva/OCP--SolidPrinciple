using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Offline : Course
    {
        public override void Subcribe(Employee emp)
        {

            Console.WriteLine("Offline Course Subcribed");
           // throw new NotImplementedException();
        }
    }
}
