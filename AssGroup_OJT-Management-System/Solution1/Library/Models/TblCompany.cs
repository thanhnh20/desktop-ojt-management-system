using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            TblJobs = new HashSet<TblJob>();
        }

        public string TaxCode { get; set; }
        public string Username { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public virtual TblAccount UsernameNavigation { get; set; }
        public virtual ICollection<TblJob> TblJobs { get; set; }
    }
}
