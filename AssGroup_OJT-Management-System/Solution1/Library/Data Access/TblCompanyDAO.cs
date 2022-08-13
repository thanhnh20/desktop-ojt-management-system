using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;


namespace Library.Data_Access
{
    public class TblCompanyDAO
    {
        //Using singleton
        private TblCompanyDAO() { }
        private static TblCompanyDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblCompanyDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblCompanyDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<dynamic> ListCompany()
        {
            OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context();           
                var result = from c in db.TblCompanies
                             select new
                             {
                                 CompanyName = c.CompanyName,
                                 CompanyTax = c.TaxCode,
                                 Email = c.Username,
                                 Address = c.Address,
                                 NumberOfJob = c.TblJobs.Count,
                             };
                return result;           
        }
        public bool CreateCompany(TblCompany company)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        TblCompany newCompany = new TblCompany()
                        {
                            TaxCode  =company.TaxCode,
                            Username = company.Username,
                            Address = company.Address,
                            CompanyName = company.CompanyName
                        };
                        TblAccount newAccount = new TblAccount()
                        {
                            Username = company.UsernameNavigation.Username,
                            Password = company.UsernameNavigation.Password,
                            IsAdmin = company.UsernameNavigation.IsAdmin
                        };
                        db.TblAccounts.Add(newAccount);
                        db.SaveChanges();

                        db.TblCompanies.Add(newCompany);
                        db.SaveChanges();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                    return false;
                }
            }
        }


        public IEnumerable<dynamic> SearchCompanyFlFilter(string choose, string txtSearch)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                IEnumerable<dynamic> listCompany = ListCompany();
                List<dynamic> result = new List<dynamic>();
                //System.Diagnostics.Debug.WriteLine(choose);
                foreach (var item in listCompany)
                {
                    bool check = true;
                    if (choose.Equals("Company name"))
                    {
                        if (txtSearch != string.Empty && !(item.CompanyName.Trim().ToLower().Contains(txtSearch.Trim().ToLower())))
                        {
                            check = false;
                        }
                    }
                    else if (choose.Equals("Company tax"))
                    {
                        if (txtSearch != string.Empty && !(item.CompanyTax.Trim().ToLower().Contains(txtSearch.Trim().ToLower())))
                        {
                            check = false;
                        }

                    }
                    else if (choose.Equals("Company address"))
                    {
                        if (txtSearch != string.Empty && !(item.Address.Trim().ToLower().Contains(txtSearch.Trim().ToLower())))
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        result.Add(item);
                    }
                }
                return result;
            }
        }

        public int GetNumberOfCompany()
        {
            int numberOfCompany = 0;
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dbContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    numberOfCompany = dbContext.TblCompanies.Count();
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return numberOfCompany;
        }

        public TblCompany GetCompanyInformation(string Email)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    return dBContext.TblCompanies.SingleOrDefault(company => company.Username.Equals(Email));
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCompanyInformation (TblCompany company)
        {
            try
            {
                using(OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    dBContext.Entry<TblCompany>(company).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dBContext.SaveChanges();
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TblCompany GetCompanyByTaxCode(string taxcode)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    return dBContext.TblCompanies.Find(taxcode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
