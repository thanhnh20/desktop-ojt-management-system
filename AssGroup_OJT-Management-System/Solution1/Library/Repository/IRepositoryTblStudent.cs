using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IRepositoryTblStudent
    {
        public void InsertStudent(TblStudent student);
        public void UpdateStudent(TblStudent student);
        public bool ChecStudentIDIsExist(string studentID);
        public IEnumerable<TblStudent> GetStudentListBySemesterID(int semesterID);
        public IEnumerable<TblStudent> GetStudentListByStudentName(int semesterID, string studentName);
        public IEnumerable<TblStudent> GetStudentListByStudentCode(int semesterID, string studentCode);
        public IEnumerable<TblStudent> GetStudentListByAddress(int semesterID, string address);
        public IEnumerable<TblStudent> GetStudentListByCredits(int semesterID, int credit);
        public IEnumerable<TblStudent> GetStudentListByMajorName(int semesterID, string major);
        public TblStudent GetStudentByStudentID(string id);
        public TblStudent GetStudentProfileByUserName(string username);
    }
}
