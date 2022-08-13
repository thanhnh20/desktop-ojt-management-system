using Library.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repository
{
    public class RepositoryTblRegisterJob : IRepositoryTblRegisterJob
    {

        public bool checkCourStatusByStudentCode(string studentCode)
            => TblRegisterJobDAO.Instance.checkCourStatusByStudentCode(studentCode);

        public bool checkStudentIsPass(string studentCode)
            => TblRegisterJobDAO.Instance.checkStudentIsPass(studentCode);

        public TblRegisterJob GetAppliedJobByIDAndStudentCode(int jobID, string studentcode)
            => TblRegisterJobDAO.Instance.GetAppliedJobByIDAndStudentCode(jobID, studentcode);
        public IEnumerable<dynamic> GetListStudentAppliedJobAsCompanyByUserName(string username)
            => TblRegisterJobDAO.Instance.GetListStudentAppliedJobAsCompanyByUserName(username);

        public void UpdateStatusApplyJobAsCompany(TblRegisterJob job) =>
            TblRegisterJobDAO.Instance.UpdateStatusApplyJobAsCompany(job);

        public IEnumerable<dynamic> SearchAppliedJobByStatusAsCompany(int status) =>
            TblRegisterJobDAO.Instance.SearchAppliedJobByStatusAsCompany(status);

        public IEnumerable<dynamic> SearchAppliedJobByJobNameAsCompany(string searchValue) =>
            TblRegisterJobDAO.Instance.SearchAppliedJobByJobNameAsCompany(searchValue);
        public int CountAppliedJobByStudentCode(string studentCode) => TblRegisterJobDAO.Instance.CountAppliedJobByStudentCode(studentCode);
        public int CountStudentActivedJobByStudentCode(string studentCode) =>
            TblRegisterJobDAO.Instance.CountStudentActivedJobByStudentCode(studentCode);
        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemester(int semesterID, string taxCode) =>
            TblRegisterJobDAO.Instance.GetIntershipInCurrentSemester(semesterID, taxCode);

        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemesterByStudentCode(int semesterID, string taxCode, string studentCode) =>
            TblRegisterJobDAO.Instance.GetIntershipInCurrentSemesterByStudentCode(semesterID: semesterID, taxCode: taxCode, studentCode: studentCode);

        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemesterByStudentName(int semesterID, string taxCode, string studentName) =>
            TblRegisterJobDAO.Instance.GetIntershipInCurrentSemesterByStudentName(semesterID, taxCode, studentName);

        public IEnumerable<TblRegisterJob> GetIntershipInCurrentSemesterByStatus(int semesterID, string taxCode, int statusStudent) =>
            TblRegisterJobDAO.Instance.GetIntershipInCurrentSemesterByStatus(semesterID, taxCode, statusStudent);

        public void UpdateInternEvaluation(TblRegisterJob evaluation) =>
            TblRegisterJobDAO.Instance.UpdateInternEvaluation(evaluation);

        public IEnumerable<TblRegisterJob> GetListStudentApplied(TblSemester currentSemester, string studentcode) =>
            TblRegisterJobDAO.Instance.GetListStudentApplied(currentSemester, studentcode);

        public void InsertRegister(TblRegisterJob registerJob) =>
            TblRegisterJobDAO.Instance.InsertRegister(registerJob);


        public void DeleteRegister(TblRegisterJob registerJob) =>
            TblRegisterJobDAO.Instance.DeleteRegister(registerJob);

        public TblRegisterJob GetStudentInternResult(string studentcode)
            => TblRegisterJobDAO.Instance.GetStudentInternResult(studentcode);

        public void UpdateRegister(TblRegisterJob registerJob) 
            => TblRegisterJobDAO.Instance.UpdateRegister(registerJob);
    }
}
