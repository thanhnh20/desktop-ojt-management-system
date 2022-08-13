using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IRepositoryTblJob
    {
        public int GetNumberOfAvailableJob();
        public int GetNumberOfInterns(TblCompany company, int companyConfirm, int studentIntern);
        public List<TblJob> GetListCompanyJobPost(TblCompany company);
        public void UpdateStatusJobAsAdmin(TblJob job);    //Admin Update Status vs Admin Confirm POST
        public TblJob GetJobByID(int idJob);           //lay post theo ID job
        public IEnumerable<dynamic> GetJobList123(); //lay cac bai post khi Load from
        
        //Admin search cac bai post cua company -------------------------------------------
        public IEnumerable<dynamic> SearchJobByCompanyNameAsAdmin(string searchValue);
        public IEnumerable<dynamic> SearchJobByJobNameAsAdmin(string searchValue);
        public IEnumerable<dynamic> SearchJobByCompanyAddressAsAdmin(string searchValue);
        //----------------------------------------------------------------------

        //Company Role -----------------------------------------------------------------
        public IEnumerable<dynamic> GetJobListAsCompany(string companyTax);
        public IEnumerable<dynamic> SearchJobByJobNameAsCompany(string jobName, string companyTax);

        public IEnumerable<dynamic> SearchJobByMajorNameAsCompany(string majorName, string companyTax);
        public void CreateNewJob(TblJob job);
        public void UpdateJob(TblJob job);
        //------------------------------------------------------------------------------


        public IEnumerable<TblJob> GetJobActive();
        public IEnumerable<TblJob> SearchJobByCompanyNameAsStudent(string searchValue);
        public IEnumerable<TblJob> SearchJobByJobNameAsStudent(string searchValue);
        public IEnumerable<TblJob> SearchJobByCompanyAddressAsStudent(string searchValue);
        public int GetNumberOfActiveJobSameMajorStudent(int majorCode);

        public IEnumerable<TblJob> SearchJobByMajorNameAsStudent(string searchValue);

    }
}
