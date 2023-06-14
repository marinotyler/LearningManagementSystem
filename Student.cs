using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherLMSApp
{
    internal class Student:IComparable<Student>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double gpa { get; set; }

        public Student(string id, string name, double gpa)
        {
            Id = id;
            Name = name;
            this.gpa = gpa;
        }

        public int CompareTo(Student other)
        {
            if(other.gpa > gpa) return -1;
            else if(other.gpa < gpa) return 1;
            else return 0;
        }

        public override string ToString() {

            return $"{this.Name}\n{this.Id}\n{this.gpa}";

        }
    }
}
