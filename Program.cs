using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Exceptions;

namespace SchoolManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        var studentService = new StudentService();
        var courseService = new CourseService();
        var gradingService = new GradingService();
    }
}