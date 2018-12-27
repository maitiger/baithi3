using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WCF.Models
{
    public class Student
    {
        [Key]
        public long StudentId { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public int  Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
