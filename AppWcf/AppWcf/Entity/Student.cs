using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWcf.Entity
{
    class Student
    {
        private long StudentId;
        private string FullName;
        private string LastName;
        private int Phone;
        private string Email;

        public long StudentId1 { get => StudentId; set => StudentId = value; }
        public string FullName1 { get => FullName; set => FullName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public int Phone1 { get => Phone; set => Phone = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
