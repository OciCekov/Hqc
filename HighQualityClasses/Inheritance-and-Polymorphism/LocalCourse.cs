namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public LocalCourse(string courseName, string teacherName = null, IList<string> attendingStudents = null,
                           string laboratory = null)
            : base(courseName, teacherName, attendingStudents)
        {
            this.Laboratory = laboratory;
        }

        // really wanted to make this "private set; but there is change in the main, so left it like this"
        // Also wanted to make "no homeless course exception", but also....
        public string Laboratory { get; set; } 

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("LocalCourse {\n Name = " + base.ToString());

            if (this.Laboratory != null)
            {
                result.Append(" Laboratory = ");
                result.Append(this.Laboratory + ";");
            }

            result.Append("\n };\n");
            return result.ToString();
        }
    }
}
