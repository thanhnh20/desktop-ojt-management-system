using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repository
{
    public interface IRepositoryTblRegisterJob
    {

        public bool checkCourStatusByStudentCode(string studentCode);

        public bool checkStudentIsPass(string studentCode);

        public TblRegisterJob GetAppliedJobByIDAndStudentCode(int jobID, string studentCode);
        public IEnumerable<dynamic> GetListStudentAppliedJobAsCompanyByUserName(string username);
        public void UpdateStatusApplyJobAsCompany(TblRegisterJob job);
        public IEnumerable<dynamic> SearchAppliedJobByStatusAsCompany(int status);
        public IEnumerable<dynamic> SearchAppliedJobByJobNameAsCompany(string searchValue);
        public int CountAppliedJobByStudentCode(string studentCode);
        public int CountStudentActivedJobByStudentCode(string studentCode);

        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemester(int semesterID, string taxCode);
        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemesterByStudentCode(int semesterID, string taxCode, string studentCode);
        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemesterByStudentName(int semesterID, string taxCode, string studentName);
        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemesterByStatus(int semesterID, string taxCode, int statusStudent);
        public void UpdateInternEvaluation(TblRegisterJob evaluation);
        public IEnumerable<TblRegisterJob> GetListStudentApplied(TblSemester currentSemester, string studentcode);
        public void InsertRegister(TblRegisterJob registerJob);

        public void DeleteRegister(TblRegisterJob registerJob);

        public TblRegisterJob GetStudentInternResult(string studentcode);
        public void UpdateRegister(TblRegisterJob registerJob);
    }
}
