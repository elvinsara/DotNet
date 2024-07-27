using Microsoft.VisualBasic;

namespace Inheritance
{
    class Person {
        public int age;
        public void Greet() {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age) { 
            this.age = age;
        }

    
    }
    class Teacher :Person {

        public void Explain()
        {
            Console.WriteLine("I'm explaining"); 
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is : {age} years old");
        }
    }

    class Student : Person
    {
        public void Study()
        {

            Console.WriteLine("I'm studying");;
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is : {age} years old");
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                //Console.WriteLine("Hello, World!");
                Person p = new Person();
                p.Greet();
                


                Student s = new Student();
                s.Greet();
                s.SetAge(23);
                s.ShowAge();
                s.Study();

                Teacher t = new Teacher();
                t.Greet();
                t.SetAge(44);
                t.ShowAge();
                t.Explain();


            }
        }
    }