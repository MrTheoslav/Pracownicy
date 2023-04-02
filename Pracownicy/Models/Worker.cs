using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pracownicy.Models;

namespace Pracownicy.Models
{
    public class Worker
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Salary { get; set; }
        public string Position { get; set; }
        public string TypeOfContract { get; set; }
    }
}
