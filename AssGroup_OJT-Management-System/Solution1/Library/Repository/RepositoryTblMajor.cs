using Library.Data_Access;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class RepositoryTblMajor : IRepositoryTblMajor
    {
        public void AddNewMajor(TblMajor newMajor) 
            => TblMajorDAO.Instance.AddNewMajor(newMajor);

        public bool CheckExitedMajor(string majorName) 
            => TblMajorDAO.Instance.CheckExitedMajor(majorName);

        public int GetNumberOfListMajor() 
            => TblMajorDAO.Instance.GetNumberOfListMajor();
        public IEnumerable<string> GetAllMajorName() 
            => TblMajorDAO.Instance.GetAllMajorName();


        public TblMajor GetMajorbyMajorName(string majorName)
            => TblMajorDAO.Instance.GetMajorbyMajorName(majorName);
        public TblMajor GetMajorByMajorCode(int majorCode) =>
            TblMajorDAO.Instance.GetMajorByMajorCode(majorCode);

    }
}
