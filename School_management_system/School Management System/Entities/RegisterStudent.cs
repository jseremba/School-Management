using School_Management_System.Serialization;
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
        public StudentImage StudentImage { get; set; } //One to One
        public Level LevelInfo { get; set; }
        public List<Subject> SubjectInfo { get; set; } //One to many
        public ClassInfo ClassInfo { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string FatherN { get; set; }
        public string MotherN { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string DateRegistered { get; set; }
        public string Religion { get; set; }
        public string PreviousSchool { get; set; }
    }
}
