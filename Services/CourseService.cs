using SchoolManagementSystem.Models;
using SchoolManagementSystem.Exceptions;

namespace SchoolManagementSystem.Services
{
    public class CourseService
    {
        private List<Course> courses = new();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourseById(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
                throw new CourseNotFoundException("Course not found.");

            return course;
        }

        public void PrintAllCourses()
        {
            foreach (var course in courses)
            {
                course.PrintDetails();
            }
        }
    }
}