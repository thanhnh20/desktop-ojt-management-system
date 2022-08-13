using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblSemester
    {
        public TblSemester()
        {
            TblStudentSemesters = new HashSet<TblStudentSemester>();
        }

        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<TblStudentSemester> TblStudentSemesters { get; set; }
    }
}
