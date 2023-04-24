using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Sliit.MTIT.student.Data;

namespace Sliit.MTIT.student.Services
{
    public class StudentService : IStudentService
    {




        public List<Models.Student> GetStudents()
        {
            return StudentMockDataService.Students;
        }


        public Models.Student GetStudent(int id)
        {
            return StudentMockDataService.Students.FirstOrDefault(x => x.Id == id);

        }


        public Models.Student AddStudent(Models.Student student)
        {
            StudentMockDataService.Students.Add(student);
            return student;
        }

       
       
      
        public Student UpdateStudent(Student student)
        {
            Models.Student selectedStudent = StudentMockDataService.Students.FirstOrDefault(x => x.Id == student.Id);
            if(selectedStudent != null)
            {
                selectedStudent.Address = student.Address;
                selectedStudent.Age = student.Age;
                selectedStudent.Name = student.Name;
                return selectedStudent;
            }
            return selectedStudent;
        }




        public bool? DeleteStudent(int id)
        {
            Models.Student selectedStudent = StudentMockDataService.Students.FirstOrDefault(x => x.Id == id);
            if (selectedStudent != null)
            {
                StudentMockDataService.Students.Remove(selectedStudent);
                return true;
            }
            return false;
        }

    }
}
