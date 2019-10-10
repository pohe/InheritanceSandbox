using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class InternationalTeacher:Teacher
    {
        public string Language { get; set; }

        public InternationalTeacher(string course, string adress, string name, int id, string language) : base(course, adress, name, id)
        {
            Language = language;
        }

    }
}
