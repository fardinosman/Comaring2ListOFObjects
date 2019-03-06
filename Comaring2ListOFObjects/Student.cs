using System;

namespace Comaring2ListOFObjects
{
    public class Student :IEquatable<Student>
    {
        public string Name;
        public int Age = 0;

        public bool Equals(Student other)
        {
            return this.Name.Equals(other.Name) && this.Age.Equals(other.Age);
        }
        public static bool operator== (Student a, Student b)
        {
            return a.Name.Equals(b.Name) && a.Age.Equals(b.Age);
        }
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
    }
}