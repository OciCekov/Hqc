namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            var localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Laboratory = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string> { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            var offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev",
                                                  new List<string> { "Thomas", "Ani", "Steve" }, "lkjhg");

            Console.WriteLine(offsiteCourse);

            var testCourse = new LocalCourse("PHP and WordPress Development", "Mario Peshev",
                                             new List<string> { "Thomas", "Ani", "Steve" }, "lkjhg");

            Console.WriteLine(testCourse);
        }
    }
}
