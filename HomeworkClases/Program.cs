using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClases
{
    class Program
    {
        public class Person
        {
            private string name;
            private int birthYear;
            public string Name
            {
                get { return name; }
                set { }
            }
            public int BirthYear
            {
                get { return birthYear; }
                set { }
            }

            public Person() { }
            public Person(string s, int b)
            {
                name = s;
                birthYear = b;
            }
            public int Age()
            {
                return DateTime.Now.Year-BirthYear;
                
            }
            public void Input(string s, int b)
            {
                name = s;
                birthYear = b;
            }
            public void ChangeName(string s)
            {
                name = s;
            }
            public override string ToString()
            {
                string str;
                return str = "Person with name: " + name + " and age: " + this.Age()+" years.";
            }
            public void Output()
            {
                Console.WriteLine(this.ToString());
            }
            public static bool operator ==(Person right, Person left)
            {
                return right.Name == left.Name;
            }
            public static bool operator !=(Person right, Person left)
            {
                return !(right == left);
            }

        }

        static void Main(string[] args)
        {
            string[] names = { "Bob", "Anna", "Ira", "Alex", "Oleg", "Max" };
            Random random = new Random();

            Person[] people =new Person[6];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(names[random.Next(0, 5)], random.Next(1990, 2010));
                people[i].Output();

            }
            Console.WriteLine("/////////////////////");
            for (int i = 1; i < people.Length; i++)
            {
                if (people[i] == people[i - 1])
                {
                    people[i].Output();
                    Console.WriteLine("Equals to");
                    people[i - 1].Output();
                }
            }
            Console.WriteLine("/////////////////////");

            foreach (var item in people)
            {
                if (item.Age()<16)
                {
                    item.ChangeName("Very Young");
                }
                item.Output();

            }
            Console.WriteLine("/////////////////////");



            Console.ReadLine();
        }
    }
}
