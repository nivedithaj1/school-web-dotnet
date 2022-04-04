using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School3.Models
{
    public class StudentModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name;
        public string Address;
        public int Age;
    }
}
