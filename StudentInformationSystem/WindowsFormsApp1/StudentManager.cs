using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StudentManager
    {
        static StudentManager studentManager;

        List<Student> students = new List<Student>()
        {
            new Student(1,"Sümeyra ERCAN","mail@gmail.com","(551) 123-4567",new DateTime(1999,2,25)),
            new Student(2,"Bera ERCAN","mail@gmail.com","(345) 123-4405",new DateTime(2003,2,11)),
            new Student(3,"Hilal ERCAN","mail@gmail.com","(123) 123-9405",new DateTime(1972,1,1)),
            new Student(4,"Mehmet ERCAN","mail@gmail.com","(324) 123-7845",new DateTime(1967,2,1)),
            new Student(5,"Barış DAl","mail@gmail.com","(555) 123-5445",new DateTime(1970,5,12))
        };
        private StudentManager()
        {

        }     
        public List<Student> GetList()
        {
            try
            {
                return students;
            }
            catch 
            {

                return new List<Student>()
                {
                     new Student(1,"Sümeyra ERCAN","mail","(551) 123-4567",new DateTime(1999,25,2)),
                     new Student(2,"Bera ERCAN","mail","(345) 123-4405",new DateTime(2003,11,2)),
                     new Student(3,"Hilal ERCAN","mail","(123) 123-9405",new DateTime(1972,1,1)),
                     new Student(4,"Mehmet ERCAN","mail","(324) 123-7845",new DateTime(1967,2,1)),
                     new Student(5,"Barış DAl","mail","(555) 123-5445",new DateTime(1970,5,12)),
                };
            }
        }
       
        public string AddStudent(Student student)
        {
            try
            {            
                if (!IsStudentComplete(student))
                {
                    return "öğrenci verileri hatalı";
                }             
                students.Add(student);
                return student.Name + " öğrencisi başarıyla eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateStudent(Student student)
        {
            try
            {
                //control
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == student.Id)
                    {
                        students[i] = student;
                        return student.Name + "öğrencisi başarıyla güncellendi";
                    }
                }               
                return "öğrenci bulunamadı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string DeleteStudent(int studentId)
        {
            try
            {
                foreach (var student in students)
                {
                    if (student.Id == studentId)
                    {
                        students.Remove(student);
                        return student.Name + " öğrencisi başarıyla silindi.";
                    }
                }
                return "Öğrenci bulunamadı";
            }
            catch (Exception ex)
            {
               return ex.Message;
            }
        }
        public Student GetStudentById(int studentId)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.Id == studentId)
                    {
                        return item;
                    }

                }
                return null;

            }
            catch 
            {

                return null;
            }
        }
        bool IsStudentComplete(Student student)
        {
            try
            {
                if (string.IsNullOrEmpty(student.Name) || string.IsNullOrEmpty(student.Mail) || string.IsNullOrEmpty(student.Phone) || student.Birthday==null)
                {
                   return false;
                }
                if (!student.Mail.Contains('@'))
                {
                //mail
                   return false;
                }
                if (student.Mail.Substring(student.Mail.Length - 4,1)!= "." && student.Mail.Substring(student.Mail.Length - 3, 1) != ".")
                {
                   return false;
                }
                MailAddress mail = new MailAddress(student.Mail);
                Convert.ToDateTime(student.Birthday);

                return true;
            }
            catch 
            {
                return false;
            }          
        }
        public int GetMaxId()
        {
            int maxId = students[students.Count-1].Id;
            return maxId+1;
        }
        public int GetStudentdByStudentName(string studentName)
        {
            foreach (var student in students)
            {
                if (student.Name == studentName)
                {
                    return student.Id;
                }
            }
            return -1;
        }

        public static StudentManager GetInstance()
        {
            if (studentManager == null)
            {
                studentManager = new StudentManager();
            }
            return studentManager;
        }
    }
    
}
