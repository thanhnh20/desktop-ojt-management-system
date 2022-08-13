using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblJob
    {
        public TblJob()
        {
            TblRegisterJobs = new HashSet<TblRegisterJob>();
        }

        public int JobCode { get; set; }
        public string JobName { get; set; }
        public int? NumberInterns { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? Status { get; set; }
        public string TaxCode { get; set; }
        public int MajorCode { get; set; }
        public int? AdminConfirm { get; set; }
        public string JobDescription { get; set; }

        public virtual TblMajor MajorCodeNavigation { get; set; }
        public virtual TblCompany TaxCodeNavigation { get; set; }
        public virtual ICollection<TblRegisterJob> TblRegisterJobs { get; set; }
    }
}
