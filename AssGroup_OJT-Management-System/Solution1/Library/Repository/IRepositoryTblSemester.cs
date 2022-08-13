using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IRepositoryTblSemester
    {
        public TblSemester GetCurrentSemester();
        public void AddNewSemester(TblSemester newSemester);
        public IEnumerable<string> GetAllSemesterName();
        public TblSemester GetSemterBySemesterID(int id);
        public TblSemester GetSemesterByName(string name);
    }
}
