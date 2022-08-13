using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Models
{
    public partial class TblAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int? IsAdmin { get; set; }

        public virtual TblCompany TblCompany { get; set; }
        public virtual TblStudent TblStudent { get; set; }
    }
}
