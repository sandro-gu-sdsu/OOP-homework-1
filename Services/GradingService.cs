using SchoolManagementSystem.Interfaces;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Exceptions;

namespace SchoolManagementSystem.Services
{
    public class GradingService : IGradingService
    {
        private List<Grade> grades = new();

        public void AssignGrade(Student student, Course course, double score)
        {
            if (score < 0 || score > 100)
            {
                throw new InvalidGradeException("Grade must be between 0 and 100.");
            }

            grades.Add(new Grade(student, course, score));

            Console.WriteLine($"Grade assigned to {student.Name}: {score}");
        }

        public void PrintGrades()
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(
                    $"Student: {grade.Student.Name}, " +
                    $"Course: {grade.Course.Title}, " +
                    $"Score: {grade.Score}"
                );
            }
        }
    }
}