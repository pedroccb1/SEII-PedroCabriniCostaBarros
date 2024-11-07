namespace DevSchool.Entities
{
    public class Student
    {
        protected Student() { }

        public Student(string fullname, DateTime birthDate, string shcoolClass)
        {
            FullName = fullname;
            BirthDate = birthDate;
            SchoolClass = shcoolClass;
            IsActive = true;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string SchoolClass { get; private set; }
        public bool IsActive { get; private set; } 
    }
}
