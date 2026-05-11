using SchoolManagementSystem.Models;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Course : IPrintable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Teacher Teacher { get; set; }

        public Course(int id, string title, Teacher teacher)
        {
            Id = id;
            Title = title;
            Teacher = teacher;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Course ID: {Id}, Title: {Title}, Teacher: {Teacher.Name}");
        }
    }
}