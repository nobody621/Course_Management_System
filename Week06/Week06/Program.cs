using Week06;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a university
            University university = new University("Tech University");

            // Create a department
            Department compSci = new Department("Computer Science");
            university.AddDepartment(compSci);

            // Create a professor
            Professor profSmith = new Professor("Dr. Smith");

            // Create a course
            Course csharpCourse = new Course("C# Programming");

            // Create a classroom
            Classroom room101 = new Classroom("101");
            csharpCourse.AssignClassroom(room101);

            // Assign professor to course
            profSmith.AssignCourse(csharpCourse);

            // Add course to department
            compSci.AddCourse(csharpCourse);

            // Create a student
            Student studentAlice = new Student("Alice", compSci);

            // Display information
            Console.WriteLine($"University: {university.Name}");
            Console.WriteLine($"Department: {compSci.Name}");
            Console.WriteLine($"Course: {csharpCourse.Title}");
            Console.WriteLine($"Professor: {profSmith.Name}");
            Console.WriteLine($"Student: {studentAlice.Name}");
            Console.WriteLine($"Classroom: {csharpCourse.Classroom.RoomNumber}");
        }
    }
}
