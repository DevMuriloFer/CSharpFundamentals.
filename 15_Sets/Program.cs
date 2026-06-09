using _15_Sets.Entities;
using _15_Sets.Utils;

try
{
    Console.Write("Enter the teacher name: ");
    string instructorName = Console.ReadLine();
    Instructor instructor = new Instructor(instructorName);
    Console.Write("Enter How many courses will be registered: ");
    int coursesQuantity = ConsoleInputHelper.ReadInt("quantity", 1, 20);
    var courses = new List<Course>();

    for(int i = 0; i < coursesQuantity; i++)
    {
        Console.Write($"\nEnter the name of the {i + 1}° Course: ");
        string courseName = Console.ReadLine();
        var course = new Course(courseName, instructor);
        Console.Write("Enter the quantity of students: ");
        var studentsQuantity = ConsoleInputHelper.ReadInt("quantity", 1, 100);
        for(int j = 0; j < studentsQuantity; j++)
        {
            Console.Write("Enter the ID of the student: ");
            var studentID = ConsoleInputHelper.ReadInt("ID", 1, 9999);
            Student student = new Student(studentID);
            course.AddStudent(student);
        }
        courses.Add(course);
    }

    HashSet<Student> students = new HashSet<Student>();
    foreach(Course course in courses)
    {
        foreach(Student std in course.Students)
        {
            students.Add(std);
        }
    }

    Console.WriteLine($"\nNumber of students in {instructorName}'s courses: {students.Count}");
}
catch (Exception e)
{
    Console.WriteLine("Sorry, an unexpected error occurred");
    Console.WriteLine($"Technical info: {e.Message}");
}
