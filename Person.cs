using System;

namespace lesson12
{
    class Person
    {
        public int Id;
        public string Name;
        public int Age;

        ////constructor
        //public Person()
        //{

        //}

        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }


        //public Person(string name)
        //{

        //}

        public void getInfo()
        {
            Console.WriteLine($"You are id:{Id} ,name is :{Name} ,you have age{Age}");

        }
    }
}
