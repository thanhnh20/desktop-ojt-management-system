using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblStudentDAO
    {
        //Using singleton
        private TblStudentDAO() { }
        private static TblStudentDAO instance = null;
        private static readonly object InstanceLock = new object();

        public static TblStudentDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblStudentDAO();
                    }
                    return instance;
                }
            }
        }


        public TblStudent GetStudentByStudentID(string id)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                return db.TblStudents.Find(id);
            };
        }

        public void InsertStudent(TblStudent student)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                db.TblStudents.Add(student);
                db.SaveChanges();
            }
        }

        public void UpdateStudent(TblStudent student)
        {
            try
            {
                using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
                {
                    db.Entry<TblStudent>(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool ChecStudentIDIsExist(string studentID)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var result = db.TblStudents.Find(studentID);
                if (result == null)
                {
                    return false;
                }
                return true;
            }
        }

        public IEnumerable<TblStudent> GetStudentListBySemesterID(int semesterID)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from student in db.TblStudents
                           join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                           where semester.SemesterId == semesterID
                           select student;
                return list.ToList();
            }
        }
        public IEnumerable<TblStudent> GetStudentListByStudentName(int semesterID, string studentName)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from student in db.TblStudents
                           join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                           where semester.SemesterId == semesterID && student.StudentName.Contains(studentName)
                           select student;
                return list.ToList();
            }
        }
        public IEnumerable<TblStudent> GetStudentListByStudentCode(int semesterID, string studentCode)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from student in db.TblStudents
                           join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                           where semester.SemesterId == semesterID && student.StudentCode.Contains(studentCode)
                           select student;
                return list.ToList();
            }
        }
        public IEnumerable<TblStudent> GetStudentListByAddress(int semesterID, string address)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from student in db.TblStudents
                           join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                           where semester.SemesterId == semesterID && student.Address.Contains(address)
                           select student;
                return list.ToList();
            }
        }
        public IEnumerable<TblStudent> GetStudentListByCredits(int semesterID, int credit)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from student in db.TblStudents
                           join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                           where semester.SemesterId == semesterID && student.Credit == credit
                           select student;
                return list.ToList();
            }
        }
        public IEnumerable<TblStudent> GetStudentListByMajorName(int semesterID, string major)
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context db = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var list = from student in db.TblStudents
                           join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                           where semester.SemesterId == semesterID && student.Majorname.Contains(major)
                           select student;
                return list.ToList();
            }
        }



        public TblStudent GetStudentProfileByUserName(string username)              //Lay DS bai POST
        {
            using (OJT_MANAGEMENT_PRN211_Vs2Context dBContext = new OJT_MANAGEMENT_PRN211_Vs2Context())
            {
                var infoStudent = dBContext.TblStudents.FirstOrDefault(stu => stu.Username == username);
                return infoStudent;
            }
        }

    }
}
