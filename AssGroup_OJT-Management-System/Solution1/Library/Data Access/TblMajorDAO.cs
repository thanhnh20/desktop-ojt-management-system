using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblMajorDAO
    {
        //Using singleton
        private TblMajorDAO() { }
        private static TblMajorDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblMajorDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblMajorDAO();
                    }
                    return instance;
                }
            }
        }

        public int GetNumberOfListMajor()
        {
            int numberOfMajor = 0;
            try
            {
                using(OJT_MANAGEMENT_PRN211_Vs2Context dbContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    numberOfMajor = dbContext.TblMajors.Count();
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return numberOfMajor;
        }

        public bool CheckExitedMajor(string majorName)
        {
            bool status = false;
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dbContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    TblMajor major = dbContext.TblMajors.SingleOrDefault(major => major.MajorName.ToLower().Equals(majorName.ToLower()));
                    if (major != null)
                    {
                        status = true;
                    }
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return status;
        }

        public void AddNewMajor(TblMajor newMajor)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dbContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    dbContext.TblMajors.Add(newMajor);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<string> GetAllMajorName()
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from major in db.TblMajors
                           select major.MajorName;
                return list.ToList();
            }
        }


        public TblMajor GetMajorbyMajorName(string majorName)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var major = db.TblMajors.Where(x => x.MajorName == majorName).FirstOrDefault();
                return major;
            }
        }

        public TblMajor GetMajorByMajorCode(int majorCode)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    return dBContext.TblMajors.Find(majorCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
