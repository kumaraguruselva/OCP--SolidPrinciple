using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal abstract class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Subcribe(Employee emp);

    }
}
