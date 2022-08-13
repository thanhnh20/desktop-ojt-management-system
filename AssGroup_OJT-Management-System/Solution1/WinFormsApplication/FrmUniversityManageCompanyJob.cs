using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Repository;

namespace WinFormsApplication
{
    public partial class FrmUniversityManageCompanyJob : Form
    {
        private readonly IRepositoryTblJob repositoryTblJob = new RepositoryTblJob();

        public FrmUniversityManageCompanyJob()
        {
            InitializeComponent();
        }

        //Method: open frm confirm job để thực hiện confirm denied or accepted job này của company
        private void DgvCompaniesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lay Job by ID Job
            var tblJob = repositoryTblJob.GetJobByID(int.Parse(txtIDJob.Text));
            if (tblJob.NumberInterns <= 0)
            {
                MessageBox.Show("This job is full", "Can't not confirm this job", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (tblJob.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("This job expired", "Can't not confirm this job", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (tblJob.Status == false)
                {
                    int adminConfirm = tblJob.AdminConfirm.Value;
                    if (adminConfirm == 0)
                    {
                        var result = MessageBox.Show("Do you want to accept this company's job?",
                            "Company Job - Confirm Company's Job",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //thực hiện thay đổi trạng thái của job này sang trạng thái accept
                            tblJob = new TblJob
                            {
                                JobCode = int.Parse(txtIDJob.Text),
                                JobName = tblJob.JobName,
                                NumberInterns = tblJob.NumberInterns,
                                ExpirationDate = tblJob.ExpirationDate,
                                Status = false,
                                TaxCode = tblJob.TaxCode,
                                MajorCode = tblJob.MajorCode,
                                JobDescription = tblJob.JobDescription,
                                AdminConfirm = 1
                            };
                            repositoryTblJob.UpdateStatusJobAsAdmin(tblJob);
                        }
                        else if (result == DialogResult.No)
                        {
                            //thực hiện thay đổi trạng thái của job này sang trạng thái dined
                            tblJob = new TblJob
                            {
                                JobCode = int.Parse(txtIDJob.Text),
                                JobName = tblJob.JobName,
                                NumberInterns = tblJob.NumberInterns,
                                ExpirationDate = tblJob.ExpirationDate,
                                Status = true,
                                TaxCode = tblJob.TaxCode,
                                MajorCode = tblJob.MajorCode,
                                JobDescription = tblJob.JobDescription,
                                AdminConfirm = 2
                            };
                            repositoryTblJob.UpdateStatusJobAsAdmin(tblJob);
                            //chuyển trạng thái hoạt động của bài job về unactive

                        }
                    }
                    else
                    {
                        if (adminConfirm == 1)
                        {
                            MessageBox.Show("This company job accepted before!", "Accepting company job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (adminConfirm == 2)
                        {
                            MessageBox.Show("This company job denied before!", "Accepting company job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } else
                {
                    MessageBox.Show("This company job is unactive!", "Accepting company job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadCompanyJob();
                // nếu là cancel thì không thay đổi gì cả
            }
        }

        //Method: thực hiện load các job lên


        //Lay danh sach cac bai post
        public void LoadCompanyJob()
        {
            try
            {
                List<dynamic> tblJobs = repositoryTblJob.GetJobList123().ToList();
                if (tblJobs != null && tblJobs.Count > 0)
                {
                    var source = new BindingSource();
                    source.DataSource = repositoryTblJob.GetJobList123().ToList();
                    txtIDJob.DataBindings.Clear();
                    txtIDJob.DataBindings.Add("Text", source, "JobCode");
                    //DgvCompaniesList.Columns[0].Visible = false;
                    DgvCompaniesList.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUniversityManageCompanyJob_Load(object sender, EventArgs e)
        {
            CbFilterJobCompanyList.Text = "Company name";
            LoadCompanyJob();
        }

        //--------------------------------------------------------------------------
        private void BtnSearchJobList_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();
            var searchFiler = CbFilterJobCompanyList.Text;
            try
            {
                switch (searchFiler)
                {
                    case "Job name":
                        source.DataSource = repositoryTblJob.SearchJobByJobNameAsAdmin(TxtSearchJobCompanyName.Text)
                            .ToList();
                        break;
                    case "Company Address":
                        source.DataSource = repositoryTblJob
                            .SearchJobByCompanyAddressAsAdmin(TxtSearchJobCompanyName.Text).ToList();
                        break;
                    default:
                        source.DataSource = repositoryTblJob.SearchJobByCompanyNameAsAdmin(TxtSearchJobCompanyName.Text)
                            .ToList();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (source.Count > 0)
            {
                txtIDJob.DataBindings.Clear();
                txtIDJob.DataBindings.Add("Text", source, "JobCode");
                DgvCompaniesList.DataSource = source;
            }
            else
            {
                MessageBox.Show("No record match!", "Search company job", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CbFilterJobCompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSearchJobCompanyName.Text = "";
        }

        private void DgvCompaniesList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvCompaniesList.Columns[e.ColumnIndex].Name == "ActionStatus")
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

            if (DgvCompaniesList.Columns[e.ColumnIndex].Name == "AdminConfirm")
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

            if (DgvCompaniesList.Columns[e.ColumnIndex].Name == "ExpirationDate") ShortFormDateFormat(e);
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