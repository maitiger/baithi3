using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WCF.Models
{
    public class StudentClass
    {
        [Key]
        public int Idclass { get; set; }
        public string NameClass { get; set; }
        [ForeignKey("StudentId")]
        public Student student { get; set; }
    }
}
