using SchoolManagementSystem.Models;
using SchoolManagementSystem.Exceptions;

namespace SchoolManagementSystem.Services
{
    public class StudentService
    {
        private List<Student> students = new();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public Student GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                throw new StudentNotFoundException("Student not found.");

            return student;
        }

        public void PrintAllStudents()
        {
            foreach (var student in students)
            {
                student.PrintDetails();
            }
        }
    }
}   