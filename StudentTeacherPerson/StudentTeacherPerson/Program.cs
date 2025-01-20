using StudentTeacherPerson;

using StudentTeacherPerson

List<Person> people = new List<Person>();

Teacher t1 = new Teacher("Musharraf", 20, "CM2342");

people.Add(t1);
people.Add(new Teacher("Alice", 35,"TE1234");
people.Add(new Teacher("Bob", 40, "FD2655"));


people.Add(new Student("Mike", 23, "ST3653");
people.Add(new Student("Steve", 20, "ST3333");
people.Add(new Student("Liam", 21, "ST9933");

foreach (Person person in people)
{
    if (p is Teacher)
    {
        Console.WriteLine(p.Name + "is a Teacher");
    }
    else
    {
        Console.WriteLine(p.Name + "is a Student");
    }
}
