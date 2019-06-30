using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademya
{
    class Program
    {
        static void Main(string[] args)
        {
            TypePrograming programing = new TypePrograming(3500);
            Student hakim = new Student("Hakim", "Memmedzade", 3500, programing);
            Student ilkin = new Student("Ilkin", "Sadiqov", 3500, programing);
            


            Code academiya = new Code("Codacademiya", "Semed vurgun 25");
            academiya.AddStudent(hakim);
            academiya.AddStudent(ilkin);
            academiya.GetAllStudent();
        }

   
      

        
    }
   
}
