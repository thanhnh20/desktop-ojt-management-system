using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Repository;
namespace WinFormsApplication
{
    public partial class FrmCompanyAddNewJob : Form
    {
        public IRepositoryTblMajor repositoryTblMajor = new RepositoryTblMajor();
        public IRepositoryTblCompany repositoryTblCompany = new RepositoryTblCompany();
        public TblAccount Account { get; set; }
        public IRepositoryTblJob RepositoryTblJob { get; set; }
        public TblJob TblJob { get; set; }
        public FrmCompanyManageJobList parentForm { get; set; }
        public FrmCompanyAddNewJob()
        {
            InitializeComponent();
        }

        //Method: Load dữ liệu của major vào combobox major
        private void FrmCompanyAddNewJob_Load(object sender, EventArgs e)
        {
            cbMajorName.DataSource = repositoryTblMajor.GetAllMajorName();
        }

        //Method: đóng form hiện tại
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInsertANewJob_Click(object sender, EventArgs e)
        {
            try
            {
                checkInput();
                checkInvalidInput();
                TblJob tblJob = new TblJob()
                {
                    JobName = TxtJobName.Text,
                    NumberInterns = int.Parse(TxtNumberOfInterns.Text),
                    ExpirationDate = DateTime.Parse(MTxtExpirationDate.Text),
                    Status = false,
                    TaxCode = repositoryTblCompany.GetCompanyInformation(Account.Username).TaxCode,
                    MajorCode = repositoryTblMajor.GetMajorbyMajorName(cbMajorName.SelectedItem.ToString()).MajorCode,
                    AdminConfirm = 0,
                    JobDescription = TxtJobDescription.Text,
                };
                RepositoryTblJob.CreateNewJob(tblJob);
                MessageBox.Show("Inserted successfully", "Insert a job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                parentForm.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void checkInput()
        {
            string msgError = "";
            bool check = true;

            if (string.IsNullOrEmpty(TxtJobName.Text.Trim()))
            {
                msgError += " - job name is empty";
                check = false;
            }
            if (string.IsNullOrEmpty(TxtNumberOfInterns.Text.Trim()))
            {
                msgError += "\n - number of intern is empty";
                check = false;
            }

            if (string.IsNullOrEmpty(TxtJobDescription.Text.Trim()))
            {
                msgError += "\n - Job Description is empty";
                check = false;
            } else
            {
                if (TxtJobDescription.Text.Length > 300)
                {
                    msgError += "\n - Job Description is required less than 300 characters.";
                }
            }
            Regex regex = new Regex(@"\d");
            if (!regex.IsMatch(MTxtExpirationDate.Text.Trim()))
            {

                msgError += "\n - Expiration Date is empty";
                check = false;
            }

            if (!check)
            {
                throw new Exception(msgError);
            }
        }
        private void checkInvalidInput()
        {
            string msgError = "";
            bool check = true;
            if (int.TryParse(TxtNumberOfInterns.Text, out var numberOfIntern))
            {
                if (numberOfIntern == 0)
                {
                    check = false;
                    msgError += "\n - Number of interns must be greater than 0";
                }
            }
            else
            {
                check = false;
                msgError += "\n - Number of interns is Number";
            }

            if (DateTime.TryParse(MTxtExpirationDate.Text, out var datetime))
            {
                DateTime now = DateTime.Now;
                if (datetime.ToString("yyyy-MM-dd").CompareTo(now.ToString("yyyy-MM-dd")) == -1)
                {
                    msgError = "\n - Expiration date needs to be greater than current date";
                    check = false;
                }
            }
            else
            {
                msgError = "\n  Expiration Date is wrong format(MM/dd/YYYY)";
                check = false;
            }

            if (!check)
            {
                throw new Exception(msgError);
            }
        }
    }
}
