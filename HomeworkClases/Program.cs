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
            public int Age()///для чого,якщо э свойство BirthYear?
            {
                return BirthYear;
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
                return str = "Person with name: " + name + " and birth year: " + birthYear;
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
            Person p1 = new Person("Pavlo", 18);
            Console.WriteLine(p1.Age());
            p1.Output();
            Console.ReadLine();
        }
    }
}
