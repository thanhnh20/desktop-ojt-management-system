using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblStudent
    {
        public TblStudent()
        {
            TblRegisterJobs = new HashSet<TblRegisterJob>();
            TblStudentSemesters = new HashSet<TblStudentSemester>();
        }

        public string StudentCode { get; set; }
        public string Username { get; set; }
        public string StudentName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public int? Credit { get; set; }
        public string Address { get; set; }
        public int? IsIntern { get; set; }
        public string Majorname { get; set; }

        public virtual TblAccount UsernameNavigation { get; set; }
        public virtual ICollection<TblRegisterJob> TblRegisterJobs { get; set; }
        public virtual ICollection<TblStudentSemester> TblStudentSemesters { get; set; }
    }
}
