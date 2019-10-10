using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        private string _adress;

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public Employee(string adress, string name, int id)
        {
            _adress = adress;
            Name = name;
            Id = id;
        }

        public virtual int CalculateSalary()
        {
            return 10000;
        }

    }
}
