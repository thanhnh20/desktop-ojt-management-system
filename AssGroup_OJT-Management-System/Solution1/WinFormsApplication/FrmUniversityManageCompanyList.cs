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
using System.Text.RegularExpressions;
namespace WinFormsApplication
{
    public partial class FrmUniversityManageCompanyList : Form
    {
        IRepositoryTblCompany repositoryTblCompany = new RepositoryTblCompany();
        public FrmUniversityManageCompanyList()
        {
            InitializeComponent();
        }

        //Method: search company theo filter và giá trị của filter
        private void BtnSearchStudentList_Click(object sender, EventArgs e)
        {
            string choose = CbFilterCompanyList.SelectedItem.ToString();
            string txtSearch = TxtSearchCompanyFollowingFilter.Text;
            var listResult = repositoryTblCompany.SearchCompanyFlFilter(choose, txtSearch).ToList();
            DgvCompanyList.DataSource = listResult.ToList();
            
            CbFilterCompanyList.Text = choose;
            if (listResult.Count == 0)
            {
                MessageBox.Show("Company list does not has any result", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DgvCompanyList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvCompanyList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvCompanyList.Columns[1].Width = 180;
                DgvCompanyList.Columns[3].Width = 180;
                DgvCompanyList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        //Method: insert a new company
        private void BtnAddNewCompany_Click(object sender, EventArgs e)
        {
            FrmUniversityAddNewCompany frmUniversityAddNewCompany = new FrmUniversityAddNewCompany();
            frmUniversityAddNewCompany.ShowDialog();
            LoadData();
                    
        }

        //Method: load dữ liệu của company vào datagridview
        private void FrmUniversityManageCompanyList_Load(object sender, EventArgs e)
        {           
            LoadData();
        }

        private void LoadData()
        {
            var listCompany = repositoryTblCompany.ListCompany().ToList();          
            List<string> filterSearch = new List<string>();
            filterSearch.Add("Company name");
            filterSearch.Add("Company tax");
            filterSearch.Add("Company address");           
            CbFilterCompanyList.DataSource = filterSearch.ToList();
            DgvCompanyList.DataSource = listCompany;
            System.Diagnostics.Debug.WriteLine(listCompany.Count);
            
            DgvCompanyList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvCompanyList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvCompanyList.Columns[1].Width = 180;
            DgvCompanyList.Columns[3].Width = 180;
            DgvCompanyList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //DgvCompanyList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
