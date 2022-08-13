using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblMajor
    {
        public TblMajor()
        {
            TblJobs = new HashSet<TblJob>();
        }

        public int MajorCode { get; set; }
        public string MajorName { get; set; }

        public virtual ICollection<TblJob> TblJobs { get; set; }
    }
}
