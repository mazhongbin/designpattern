using System.Collections.Generic;

namespace DP17Iterator.V1
{
    public class Clazz : Aggregate<Student>
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override Iterator<Student> CreateIterator()
        {
            return new ClazzIterator(this);
        }

        public int StudentCount { get { return students.Count; } }

        public Student this[int index] { get { return students[index]; } }
    }
}
