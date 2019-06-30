using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademya
{
    class Code
    {
        private static int ID;
        public string Name { get; set; }
        public string Adress { get; set; }
        private Student[] students;
       
        public Code(string name,string adress)
        {
            ID++;
            Name = name;
            Adress = adress;
            students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length+1);
            students[students.Length - 1] = student;
        }
        public void GetAllStudent()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name},pulu: {item.Money}");
            }
        }
    }
}
