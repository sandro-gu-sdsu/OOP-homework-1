using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Interfaces
{
    public interface IGradingService
    {
        void AssignGrade(Student student, Course course, double score);
    }
}