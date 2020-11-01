using System;
using System.Security.Cryptography.X509Certificates;

namespace lesson12
{
    public class Student
    {
        public string Name;
        public string subject1;
        public string subject2;
        public string subject3;
        public double degree1;
        public double degree2;
        public double degree3;
        public Student(string name, string subject1, string subject2, string subject3, double degree1, double degree2, double degree3)
        {
            this.Name = name;
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.subject3 = subject3;
            this.degree1 = degree1;
            this.degree2 = degree2;
            this.degree3 = degree3;
        }
    }
}
