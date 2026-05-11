using SchoolManagementSystem.Models;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Student : Person, IPrintable
    {
        public float GPA { get; set; }
        public Student(int id, string name, float gpa) : base(id, name)
        {
            GPA = gpa;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}, GPA: {GPA}");
        }
    }
}