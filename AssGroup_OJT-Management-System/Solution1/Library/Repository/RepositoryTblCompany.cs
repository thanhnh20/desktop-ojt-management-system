using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data_Access;
using Library.Models;

namespace Library.Repository
{
    public class RepositoryTblCompany : IRepositoryTblCompany
    {

        public bool CreateCompany(TblCompany company)
                => TblCompanyDAO.Instance.CreateCompany(company);

        public TblCompany GetCompanyByTaxCode(string taxcode)
            => TblCompanyDAO.Instance.GetCompanyByTaxCode(taxcode);

        public TblCompany GetCompanyInformation(string Email) 
            => TblCompanyDAO.Instance.GetCompanyInformation(Email);

        public int GetNumberOfCompany()
                => TblCompanyDAO.Instance.GetNumberOfCompany();

        public IEnumerable<dynamic> ListCompany()
                => TblCompanyDAO.Instance.ListCompany();

        public IEnumerable<dynamic> SearchCompanyFlFilter(string choose, string txtSearch)
                => TblCompanyDAO.Instance.SearchCompanyFlFilter(choose, txtSearch);

        public void UpdateCompanyInformation(TblCompany company)
                => TblCompanyDAO.Instance.UpdateCompanyInformation(company);
    }
}
