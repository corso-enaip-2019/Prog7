using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentClasse
{
    class ClassRoom
    {
        

        public ClassRoom(int grade)
        {
            Grade = grade;
            Students = new List<Student>();
        }


        public int Grade { get;  }


        public List<Student> Students { get; }

        public void AddStudent(Student student)
        {
            _students.Add(students);
        }
    }
}
