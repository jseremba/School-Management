using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Entities
{
    public class StudentImage
    {
        [PrimaryKey, AutoIncrement]
        public Int32 Auto_Sequence { get; set; }
        public byte[] MyImageLogo { get; set; }
        public string Regnumber { get; set; }
    }
}
