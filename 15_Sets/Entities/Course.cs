namespace _15_Sets.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        public Instructor Instructor { get; set; }
        public HashSet<Student> Students { get; set; } = new HashSet<Student>();

        public Course(string name, Instructor instructor)
        {
            Name = name;
            Instructor = instructor;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                throw new ArgumentException("The Student to be removed is not on the list");
            }
            Students.Remove(student);
        }
    }
}
