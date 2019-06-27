using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Job test = new Job("developer");
            //Person hakim = new Person("Hakim",test);
            //Console.WriteLine($"{hakim.Name} {hakim.Work.Name}"); 
            //Person.WriteName("Ilkin");

            //Console.WriteLine(kenan.MyProperty);
            //Console.WriteLine(Person.Count);


            //Person kenan = new Person();
            //Person ferid = new Person();
            //Person mushfiq = new Person();

            //Person[] people = { cavid, kenan, ferid, mushfiq };
            //int[] x = { 5, 7, 87};
            //int[] y = new int[5] { 5, 6, 7, 8, 9 };
            //Array.Resize(ref y, 10);

            Person cavid = new Person("Cavid","Bashirov");
            Console.WriteLine(cavid.ToString());

        }

    }

    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }

    static class Animal
    {
        public static int MyProperty { get; set; }
    }

    

    internal class Job
    {
        public string Name { get; set; }

        public Job(string name)
        {
            Name = name;
        }
    }
}
