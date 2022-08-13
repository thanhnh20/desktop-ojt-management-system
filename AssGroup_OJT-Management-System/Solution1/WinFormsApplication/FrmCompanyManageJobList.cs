using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Repository;
using Library.Models;
namespace WinFormsApplication
{
    public partial class FrmCompanyManageJobList : Form
    {
        IRepositoryTblJob repositoryTblJob = new RepositoryTblJob();
        IRepositoryTblCompany repositoryTblCompany = new RepositoryTblCompany();
        IRepositoryTblMajor repositoryTblMajor = new RepositoryTblMajor();
        public FrmCompanyManageJobList()
        {
            InitializeComponent();
        }

        public TblAccount CompanyAccount { get; set; }

        //Method: Load dữ liệu của các bài job của công ty này
        private void FrmCompanyManageJobList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var company = repositoryTblCompany.GetCompanyInformation(CompanyAccount.Username);
            var listJob = repositoryTblJob.GetJobListAsCompany(company.TaxCode).ToList();
            if (listJob != null && listJob.Count() > 0)
            {
                DgvCompanyJobList.DataSource = listJob;
                DgvCompanyJobList.Columns[0].Visible = false;
                for (int i = 1; i < listJob.Count; i++)
                {
                    DgvCompanyJobList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            List<string> listSearchOption = new List<string>();
            listSearchOption.Add("Job name");
            listSearchOption.Add("Major name");
            CbFilterJobCompanyList.DataSource = listSearchOption;
        }
        private void LoadData(List<dynamic> listJob, string searchOption)
        {
            
            DgvCompanyJobList.DataSource = listJob;
            DgvCompanyJobList.Columns[0].Visible = false;
            for (int i = 1; i < listJob.Count; i++)
            {
                DgvCompanyJobList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            //DgvCompanyJobList.Columns[listJob.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CbFilterJobCompanyList.Text = searchOption;

        }
        //Method: Search job company theo fiter và giá trị tên được nhập vào
        private void BtnSearchJobList_Click(object sender, EventArgs e)
        {
            var searchOption = CbFilterJobCompanyList.SelectedItem.ToString();
            var searchValue = TxtSearchJobCompanyName.Text;
            var company = repositoryTblCompany.GetCompanyInformation(CompanyAccount.Username);
            List<dynamic> listResult;
            
            if (searchOption.Equals("Job name"))
            {
                listResult = repositoryTblJob.SearchJobByJobNameAsCompany(searchValue, company.TaxCode).ToList();
                if(listResult.Count == 0)
                {
                    MessageBox.Show("Company list does not has any result", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadData(listResult, searchOption);
                }
                
            }
            if (searchOption.Equals("Major name"))
            {
                listResult = repositoryTblJob.SearchJobByMajorNameAsCompany(searchValue, company.TaxCode).ToList();
                if (listResult.Count == 0)
                {
                    MessageBox.Show("Company list does not has any result", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LoadData(listResult, searchOption);
                }

            }
        }

        //Method: Open form add new company 
        private void BtnAddNewCompany_Click(object sender, EventArgs e)
        {
            FrmCompanyAddNewJob frmCompanyAddNewJob = new FrmCompanyAddNewJob()
            {
                RepositoryTblJob = repositoryTblJob,
                Account = CompanyAccount,
                parentForm = this,
            };
            frmCompanyAddNewJob.Show();
            LoadData();
        }

        //Method: open form update job information
        private void DgvCompanyJobList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCompanyUpdateJobInformation frmCompanyUpdateJobInformation = new FrmCompanyUpdateJobInformation()
            {
                RepositoryTblJob = repositoryTblJob,
                Account = CompanyAccount,
                TblJob = GetJobAtRowSelect(),
                parentForm = this
            };
            frmCompanyUpdateJobInformation.Show();
        }
        
        private TblJob GetJobAtRowSelect()
        {
            var majorName = DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            var majorCode = repositoryTblMajor.GetMajorbyMajorName(majorName).MajorCode;
            var Member = new TblJob()
            {
                JobCode = int.Parse(DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[0].Value.ToString()),
                JobName = DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[1].Value.ToString(),
                MajorCode = majorCode,
                NumberInterns =int.Parse(DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[3].Value.ToString()),
                ExpirationDate = DateTime.Parse(DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[4].Value.ToString()),
                JobDescription = DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[5].Value.ToString(),
                Status = bool.Parse(DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[6].Value.ToString()),
                AdminConfirm = int.Parse(DgvCompanyJobList.SelectedCells[0].OwningRow.Cells[7].Value.ToString()),
            };
            return Member;
        }

        private void DgvCompanyJobList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvCompanyJobList.Columns[e.ColumnIndex].Name == "ActionStatus")
            {
                if (e.Value != null && e.Value.ToString().Equals("False"))

                {
                    e.Value = new string("Active");
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = new string("Unactive");
                    e.CellStyle.ForeColor = Color.Red;
                }
            }

            if (DgvCompanyJobList.Columns[e.ColumnIndex].Name == "AdminConfirm")
            {
                if (e.Value != null && e.Value.Equals(1))

                {
                    e.Value = new string("Accepted");
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value != null && e.Value.Equals(2))
                {
                    e.Value = new string("Denied");
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.Value = new string("Not Yet");
                }
            }

            if (DgvCompanyJobList.Columns[e.ColumnIndex].Name == "ExpirationDate") ShortFormDateFormat(e);
        }
        //FormatDate
        private void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
                try
                {
                    var dateString = new StringBuilder();
                    var theDate = DateTime.Parse(formatting.Value.ToString());

                    dateString.Append(theDate.Day);
                    dateString.Append("/");
                    dateString.Append(theDate.Month);
                    dateString.Append("/");
                    dateString.Append(theDate.Year);
                    formatting.Value = dateString.ToString();
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    // Set to false in case there are other handlers interested trying to
                    // format this DataGridViewCellFormattingEventArgs instance.
                    formatting.FormattingApplied = false;
                }
        }
    }
}
