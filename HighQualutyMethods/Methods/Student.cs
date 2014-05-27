namespace Methods
{
    using System;

  public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student student)
        {
            var firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            var secondDate = DateTime.Parse(student.OtherInfo.Substring(student.OtherInfo.Length - 10));
            return firstDate > secondDate;
        }
    }
}
