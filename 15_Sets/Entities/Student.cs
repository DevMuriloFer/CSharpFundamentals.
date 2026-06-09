namespace _15_Sets.Entities
{
    internal class Student : IComparable<Student>
    {
        public int StudentID { get; set; }

        public Student(int studentID)
        {
            StudentID = studentID;
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1;
            return StudentID.CompareTo(other.StudentID);
        }
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj is Student)
            {
                var other = obj as Student;
                return StudentID.Equals(other.StudentID);
            }
            return false;
        }
    }
}
