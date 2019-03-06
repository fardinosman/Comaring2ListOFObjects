using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comaring2ListOFObjects
{
    class Program
    {/// <summary>
    /// /
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.Name = "hello";
            s2.Name = "hello1";

            if (s1 ==s2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false ");
            }
            List<Student> list1 = new List<Student>();
            list1.Add(s1);
            list1.Add(s2);

            Student s3 = new Student();
            Student s4 = new Student();
            s3.Name = "hello";
            s4.Name = "hello1";

            List<Student> list2 = new List<Student>();
            list2.Add(s3);
            list2.Add(s4);

            if (list2.Contains(s1))
            {
                Console.WriteLine("true");
            }
            if (list2.SequenceEqual(list1))
            {
                Console.WriteLine(" checking sequence true");
            }
            if (list2.All(x=>list1.Contains(x)))
            {
                Console.WriteLine("list.all :  true");
            }
        }
    }
}
