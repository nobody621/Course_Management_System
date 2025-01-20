using ClassRoomQuestion;

class Program
{
    static void Main(string[] args)
    {
        // Creating Teacher
        Teacher t1 = new Teacher("Mr Smith", 40, "CB014022");

        // Creating ClassRoom and assigning teacher
        ClassRoom classroom = new ClassRoom("Grade 10", 5, t1);

        // Adding teacher to the classroom
        classroom.AddTeacher(t1);

        // Creating students
        Student s1 = new Student("John Doe", 15, "S001");
        Student s2 = new Student("Jane Doe", 14, "S002");

        // Adding students to the classroom
        classroom.AddStudent(s1);
        classroom.AddStudent(s2);

        // Removing a student
        classroom.RemoveStudent(s1);
    }
}