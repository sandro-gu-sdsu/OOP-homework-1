using SchoolManagementSystem.Models;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Teacher : Person, IPrintable
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string subject) : base(id, name)
        {
            Subject = subject;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Teacher ID: {Id}, Name: {Name}, Subject: {Subject}");
        }
    }
}