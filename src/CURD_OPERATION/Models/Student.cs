using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_OPERATION.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        [Required]
        [StringLength(255, MinimumLength =5)]
        public string Name { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string RegistrationNumber { get; set; }
    }
}
