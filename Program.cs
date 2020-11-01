using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace lesson12
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            //int x = 10;
            //var x=10;

            //First object
            // Person person = new Person();
            //var person1 = new Person();
            //person1.id = 100;
            //person1.name = "roya";
            //person1.age = 31;


            //var person2 = new Person();
            //person2.id = 200;
            //person2.name = "saeed";
            //person2.age = 100;



            //List<Person> students = new List<Person>();
            //students.Add(person1);
            //students.Add(person2);


            //foreach (var student in students)
            //{
            //    student.getInfo();

            //}
            //Console.ReadKey();


            //DatabaseConfig.Id = 1;
            //DatabaseConfig.Connection();


            //Person p1 = new Person(1, "roay", 31);
            //Person p2 = new Person(2, "saeed", 31);
            //Person p3=new Person()

            //p1.getInfo();

            List<Student> students = new List<Student>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter name");
                var name = Console.ReadLine();

                Console.WriteLine("Enter subject A");
                var subject1 = Console.ReadLine();

                Console.WriteLine("Enter degree A");
                var degree1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter subject B");
                var subject2 = Console.ReadLine();

                Console.WriteLine("Enter degree B");
                var degree2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter subject C");
                var subject3 = Console.ReadLine();

                Console.WriteLine("Enter degree C");
                var degree3 = Convert.ToDouble(Console.ReadLine());

                var student = new Student(name, subject1, subject2, subject3, degree1, degree2, degree3);
                students.Add(student);
            }

            CalculageDegree cal = new CalculageDegree();
            Console.WriteLine($"average degree:{cal.getAverge("a", students)}");
            Console.WriteLine($"Max degree:{cal.MaxStudent("a", students)}");
            Console.WriteLine($"Min degree: {cal.MinStudnet("a", students)}");
            Console.ReadKey();
        }



    }
}
