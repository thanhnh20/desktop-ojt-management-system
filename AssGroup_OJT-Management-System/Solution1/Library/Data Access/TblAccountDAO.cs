using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblAccountDAO
    {
        //Using singleton
        private TblAccountDAO() { }
        private static TblAccountDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblAccountDAO Instance
        {
            get
            {
                lock(InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblAccountDAO();
                    }
                    return instance;
                }
            }
        }

        public TblAccount CheckLogin(string email, string password)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    return dBContext.TblAccounts.SingleOrDefault(account => account.Username.Equals(email) && account.Password.Equals(password));
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CheckAvailabelAccount(string email)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    TblAccount account = dBContext.TblAccounts.SingleOrDefault(account => account.Username.Equals(email));
                    if (account != null)
                    {
                        return true;
                    }
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        // hàm kiểm tra Email đã tồn tại chưa 
        public bool CheckEmailIsExist(String email)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var result = db.TblAccounts.Find(email);
                if (result != null)
                {
                    return true;
                }

                return false;
            }
        }

        public TblAccount GetAccountByEmail(string email)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                return db.TblAccounts.Find(email);
            }
        }

        public void InsertAccount(TblAccount account)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                db.TblAccounts.Add(account);
                db.SaveChanges();
            }
        }

        public void UpdateAccount (TblAccount account)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var result = db.TblAccounts.Find(account.Username);
                result.Password = account.Password;
                db.SaveChanges();
            }
        }
    }
}
