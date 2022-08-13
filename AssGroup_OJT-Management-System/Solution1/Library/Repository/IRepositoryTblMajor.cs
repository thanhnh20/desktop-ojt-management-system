using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IRepositoryTblMajor
    {
        public int GetNumberOfListMajor();
        public bool CheckExitedMajor(string majorName);
        public void AddNewMajor(TblMajor newMajor);
        public IEnumerable<string> GetAllMajorName();
        public TblMajor GetMajorbyMajorName(string majorName);
        public TblMajor GetMajorByMajorCode(int majorCode);

    }
}
