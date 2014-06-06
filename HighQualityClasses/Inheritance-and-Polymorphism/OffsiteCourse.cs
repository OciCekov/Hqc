namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string courseName, string teacherName = null, IList<string> attendingStudents = null,
                             string initialTown = null)
            : base(courseName, teacherName, attendingStudents)
        {
            this.Town = initialTown;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("OffsiteCourse {\n Name = " + base.ToString());

            if (this.Town != null)
            {
                result.Append(" Town = ");
                result.Append(this.Town + ";");
            }

            result.Append("\n };\n");
            return result.ToString();
        }
    }
}
