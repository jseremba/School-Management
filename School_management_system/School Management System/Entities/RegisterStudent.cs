using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Entities
{
    public class RegisterStudent
    {
        [AutoIncrement, PrimaryKey]
        public int StudentId { get; set; }
        public string Regnumber { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Sex { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string FatherN { get; set; }
        public string MotherN { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string DateRegistered { get; set; }
    }
}
