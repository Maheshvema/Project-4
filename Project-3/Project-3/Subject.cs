using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Subject
    {
        public string Name { get; set; }
        public string SubCode { get; set; }

        public Subject(string name, string code)
        {
            Name = name;
            SubCode = code;
        }
    }
}

