namespace SchoolManagementSystem.Models
{
    public class Grade
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public double Score { get; set; }

        public Grade(Student student, Course course, double score)
        {
            Student = student;
            Course = course;
            Score = score;
        }
    }
}