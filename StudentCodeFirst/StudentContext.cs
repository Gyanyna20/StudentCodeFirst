using System.Data.Entity;

namespace StudentCodeFirst
{
    // DbContext manages the connection to the database and tracks changes.
    public class StudentContext : DbContext
    {
        // The DbSet represents the Students table in the database.
        public DbSet<Student> Students { get; set; }
    }
}
