using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Entities
{
    public class Teacher
    {
        public List<Level> TeacherLevel { get; set; }
        public List<Subject> TeacherSubjects { get; set; }
        public List<ClassInfo> TeacherClasses { get; set; }
        public String Class_ { get; set; }
        public string Fullname { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
    }
}
