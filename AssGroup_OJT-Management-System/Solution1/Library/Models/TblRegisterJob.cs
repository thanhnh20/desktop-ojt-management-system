using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblRegisterJob
    {
        public string StudentCode { get; set; }
        public int JobCode { get; set; }
        public double? Grade { get; set; }
        public string Comment { get; set; }
        public bool? StudentConfirm { get; set; }
        public int? IsCompanyConfirm { get; set; }
        public bool? IsPass { get; set; }
        public int? Aspiration { get; set; }

        public virtual TblJob JobCodeNavigation { get; set; }
        public virtual TblStudent StudentCodeNavigation { get; set; }
    }
}
