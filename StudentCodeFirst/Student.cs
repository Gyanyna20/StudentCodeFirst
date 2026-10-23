namespace StudentCodeFirst
{
    // This class is the Code-First model.
    // Entity Framework uses its properties to define columns in the Students table.
    public class Student
    {
        // Entity Framework recognizes StudentId as the primary key by convention.
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
