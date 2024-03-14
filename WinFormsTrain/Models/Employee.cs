using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTrain.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SurName { get; set; }
        public string? JobTitle { get; set; }
        
        public int Salary { get; set; }

        public string? Role { get; set; }
    }
}
