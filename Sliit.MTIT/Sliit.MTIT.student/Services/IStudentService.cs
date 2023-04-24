using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliit.MTIT.student.Services
{
    interface IStudentService
    {

        List<Models.Student> GetStudents();
        Models.Student GetStudent(int id);
        Models.Student AddStudent(Models.Student student);
        Models.Student UpdateStudent(Models.Student student);

        bool? DeleteStudent(int id);
    }
}
