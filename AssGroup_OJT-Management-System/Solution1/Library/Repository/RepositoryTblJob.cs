using Library.Data_Access;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class RepositoryTblJob : IRepositoryTblJob
    {
        public List<TblJob> GetListCompanyJobPost(TblCompany company) 
            => TblJobDAO.Instance.GetListCompanyJobPost(company);

        public int GetNumberOfAvailableJob() 
            => TblJobDAO.Instance.GetNumberOfAvailableJob();

        public int GetNumberOfInterns(TblCompany company, int companyConfirm, int studentIntern)
            => TblJobDAO.Instance.GetNumberOfInterns(company, companyConfirm, studentIntern);


        public void UpdateStatusJobAsAdmin(TblJob job) 
            => TblJobDAO.Instance.UpdateStatusJobAsAdmin(job); //Admin Update Status vs Admin Confirm POST
        public TblJob GetJobByID(int jobID) 
            => TblJobDAO.Instance.GetJobByID(jobID); //Lay bai post theo ID post
        public IEnumerable<dynamic> GetJobList123() 
            => TblJobDAO.Instance.GetJobList123(); ////Lay cac bai post

        //Admin search cac bai post cua company -------------------------------------------
        public IEnumerable<dynamic> SearchJobByCompanyNameAsAdmin(string searchValue) 
            => TblJobDAO.Instance.SearchJobByCompanyNameAsAdmin(searchValue);
        public IEnumerable<dynamic> SearchJobByJobNameAsAdmin(string searchValue)
            => TblJobDAO.Instance.SearchJobByJobNameAsAdmin(searchValue);
        public IEnumerable<dynamic> SearchJobByCompanyAddressAsAdmin(string searchValue) 
            => TblJobDAO.Instance.SearchJobByCompanyAddressAsAdmin(searchValue);
        //----------------------------------------------------------------------

        //Company Role ---------------------------------------------------------------------
        public IEnumerable<dynamic> GetJobListAsCompany(string companyTax) => TblJobDAO.Instance.GetJobListAsCompany(companyTax);
        public IEnumerable<dynamic> SearchJobByJobNameAsCompany(string jobName, string companyTax) => TblJobDAO.Instance.SearchJobByJobNameAsCompany(jobName, companyTax);
        public IEnumerable<dynamic> SearchJobByMajorNameAsCompany(string majorName, string companyTax) => TblJobDAO.Instance.SearchJobByMajorNameAsCompany(majorName, companyTax);
        public void CreateNewJob(TblJob job) => TblJobDAO.Instance.CreateNewJob(job);
        public void UpdateJob(TblJob job) => TblJobDAO.Instance.UpdateJob(job);
        //----------------------------------------------------------------------------------


        //Student search--------------------
        public IEnumerable<TblJob> GetJobActive() => TblJobDAO.Instance.GetJobActive();

        public IEnumerable<TblJob> SearchJobByCompanyNameAsStudent(string searchValue) =>
            TblJobDAO.Instance.SearchJobByCompanyNameAsStudent(searchValue);

        public IEnumerable<TblJob> SearchJobByJobNameAsStudent(string searchValue) =>
            TblJobDAO.Instance.SearchJobByJobNameAsStudent(searchValue);

        public IEnumerable<TblJob> SearchJobByCompanyAddressAsStudent(string searchValue) =>
            TblJobDAO.Instance.SearchJobByCompanyAddressAsStudent(searchValue);

        public int GetNumberOfActiveJobSameMajorStudent(int majorCode) => 
            TblJobDAO.Instance.GetNumberOfActiveJobSameMajorStudent(majorCode);
        public IEnumerable<TblJob> SearchJobByMajorNameAsStudent(string searchValue) =>
            TblJobDAO.Instance.SearchJobByMajorNameAsStudent(searchValue);
        //----------------------------------------------------------------------

    }
}
