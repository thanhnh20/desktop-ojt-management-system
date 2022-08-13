using Library.Models;
using Library.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Repository;

namespace Library.Repository
{
    public interface IRepositoryTblStudentSemester
    {
        public int GetNumberOfStudentOfCurrentSemester(TblSemester currentSemester);

        public IEnumerable<TblStudentSemester> GetStudentInOtherSemester(string studentCode);
        public void InsertStuSemester(TblStudentSemester stuSemester);
        public bool CheckStudentAndSemesterIsExist(TblStudentSemester stuSem);
    }
}
