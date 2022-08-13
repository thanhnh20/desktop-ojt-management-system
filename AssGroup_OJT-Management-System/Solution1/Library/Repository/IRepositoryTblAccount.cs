using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
namespace Library.Repository
{
    public interface IRepositoryTblAccount
    {
        public TblAccount CheckLogin(string email, string password);
        public bool CheckAvailabelAccount(string email);
        public bool CheckEmailIsExist(String email);
        public TblAccount GetAccountByEmail(string email);

        public void InsertAccount(TblAccount account);
        public void UpdateAccount(TblAccount account);
    }
}
