using System;
using System.Linq;

namespace StudentCodeFirst
{
    internal class Program
    {
        private static void Main()
        {
            // The using statement makes sure the database context is disposed
            // when we have finished using it.
            using (var db = new StudentContext())
            {
                // Create one new student object.
                var student = new Student
                {
                    FirstName = "Gia",
                    LastName = "Bu",
                    Age = 21
                };

                // Add the student to the Students table and save the change.
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student saved successfully.");
                Console.WriteLine();

                // Read the students currently stored in the database.
                foreach (var savedStudent in db.Students.ToList())
                {
                    Console.WriteLine(
                        "ID: {0}, Name: {1} {2}, Age: {3}",
                        savedStudent.StudentId,
                        savedStudent.FirstName,
                        savedStudent.LastName,
                        savedStudent.Age);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
