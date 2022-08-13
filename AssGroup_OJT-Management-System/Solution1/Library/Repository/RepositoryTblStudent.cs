using Library.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data_Access;
using Library.Models;

namespace Library.Repository
{
    public class RepositoryTblStudent : IRepositoryTblStudent
    {

        public void InsertStudent(TblStudent student) 
            => TblStudentDAO.Instance.InsertStudent(student);
        public bool ChecStudentIDIsExist(string studentID) 
            => TblStudentDAO.Instance.ChecStudentIDIsExist(studentID);

        public TblStudent GetStudentByStudentID(string id) 
            => TblStudentDAO.Instance.GetStudentByStudentID(id);

        public IEnumerable<TblStudent> GetStudentListByAddress(int semesterID, string address) 
            => TblStudentDAO.Instance.GetStudentListByAddress(semesterID, address);

        public IEnumerable<TblStudent> GetStudentListByCredits(int semesterID, int credit) 
            => TblStudentDAO.Instance.GetStudentListByCredits(semesterID, credit);

        public IEnumerable<TblStudent> GetStudentListByMajorName(int semesterID, string major) 
            => TblStudentDAO.Instance.GetStudentListByMajorName(semesterID, major);

        public IEnumerable<TblStudent> GetStudentListBySemesterID(int semesterID) 
            => TblStudentDAO.Instance.GetStudentListBySemesterID(semesterID);

        public IEnumerable<TblStudent> GetStudentListByStudentCode(int semesterID, string studentCode) 
            => TblStudentDAO.Instance.GetStudentListByStudentCode(semesterID, studentCode);

        public IEnumerable<TblStudent> GetStudentListByStudentName(int semesterID, string studentName) 
            => TblStudentDAO.Instance.GetStudentListByStudentName(semesterID,studentName);

        public void UpdateStudent(TblStudent student) 
            => TblStudentDAO.Instance.UpdateStudent(student);

        public TblStudent GetStudentProfileByUserName(string username) =>
            TblStudentDAO.Instance.GetStudentProfileByUserName(username);

    }
}
