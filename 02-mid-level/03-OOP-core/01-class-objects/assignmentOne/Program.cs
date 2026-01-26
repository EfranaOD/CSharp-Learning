using System;

namespace assignmentOne
{
    class Person
    {
        public string ID { get; }
        private static int _personCount;
        public string _name { get; private set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new Exception("Age cannot be negative");
                _age = value;
            }
        }
        public Person(string name, int Age, string iD)
        {
            _name = name;
            this.Age = Age;
            ID = iD;
            _personCount++;
        }
        public static int PersonCount
        {
            get { return _personCount; }
        }
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {this._name} and I am {this.Age} years old.");
        }
        public void ChangeName(string newName)
        {
            if (newName == null)
                throw new Exception("Name cannot be null");
            _name = newName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Dazai Osamu", 39, "P1001");
            personOne.Introduce();

            Person personTwo = new Person("Nakahara Chuuya", 30, "P1002");
            personTwo.Introduce();

            Person personThree = new Person("Akutagawa Ryunosuke", 35, "P1003");
            personThree.Introduce();

            //personOne._name = "efrana";

            Console.WriteLine($"Total Person created: {Person.PersonCount}");
        }
    }
}