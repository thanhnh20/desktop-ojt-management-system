using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblStudentSemester
    {
        public int RecordId { get; set; }
        public string StudentCode { get; set; }
        public int? SemesterId { get; set; }

        public virtual TblSemester Semester { get; set; }
        public virtual TblStudent StudentCodeNavigation { get; set; }
    }
}
