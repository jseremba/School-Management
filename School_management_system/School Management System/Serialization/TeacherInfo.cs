using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Serialization
{
    public class TeacherInfo
    {
        public List<LevelInfo> OutTeacherInfo_Out_Level { get; set; }
        public List<SubjectInfo> OutTeacherInfo_OutSubjects { get; set; }
        public List<ClassInfo> OutTeacherInfo_OutClasses { get; set; }
        public String Class_ { get; set; }
    }
}
