
using System.Collections.Generic;

namespace Sliit.MTIT.student.Data
{
    public static class StudentMockDataService
    {


        public static List<Models.Student> Students = new List<Models.Student>()
        {
            new Models.Student { Id=1,Name ="Jhon",Address="123",Age=28 },
            new Models.Student { Id=2,Name ="Marry",Address="564",Age=21 },
            new Models.Student { Id=3,Name ="Tony",Address="789",Age=22 }
        };

    }
}
