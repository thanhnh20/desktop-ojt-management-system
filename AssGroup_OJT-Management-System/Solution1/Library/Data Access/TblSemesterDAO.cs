using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblSemesterDAO
    {
        //Using singleton
        private TblSemesterDAO() { }
        private static TblSemesterDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblSemesterDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblSemesterDAO();
                    }
                    return instance;
                }
            }
        }

        public TblSemester GetCurrentSemester()
        {
            TblSemester semester = null;
            List<TblSemester> listSemester = null;
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    listSemester = dBContext.TblSemesters.ToList();
                    if (listSemester.Count > 0)
                    {
                        semester = listSemester.OrderByDescending(semester => semester.EndDate).First();
                    }
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return semester;
        }

        public void AddNewSemester(TblSemester newSemester)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dbContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    dbContext.TblSemesters.Add(newSemester);
                    dbContext.SaveChanges();
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<string> GetAllSemesterName()
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from c in db.TblSemesters
                           orderby c.StartDate descending
                           select c.SemesterName;
                return list.ToList();
            }
        }
        public TblSemester GetSemterBySemesterID(int id)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                return db.TblSemesters.Find(id);
            }
        }

        public TblSemester GetSemesterByName(string name)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var result = from semester in db.TblSemesters
                             where semester.SemesterName == name
                             select semester;
                return result.FirstOrDefault();
            }
        }
    }
}
