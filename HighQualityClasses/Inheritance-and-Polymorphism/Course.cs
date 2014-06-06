namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        protected Course(string courseName, string teacherName = null, IList<string> attendingStudents = null, string lab = null)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = attendingStudents;
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                // with Exception, maybe?
                return "{ }\n";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " };\n";
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("\n Teacher = ");
                result.Append(this.TeacherName);
            }

            if (this.Students != null)
            {
                result.Append(";\n Students = ");
                result.Append(this.GetStudentsAsString());
            }

            return result.ToString();
        }
    }
}
