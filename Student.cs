using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Student
    {
            static void Main(string[] args)
            {
            int ch;
            Studentmngmt ob = new Studentmngmt();
            Console.WriteLine("STUDENT DATABASE");
            Console.WriteLine("1.New Student\n2.Old Student\nEnter the choice: ");
            ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                ob.newstudentdetails();
                ob.deptdetails();
                ob.fees();
                ob.newdisplay();
               
            }
            else if (ch == 2)
            {
                ob.oldstudent();
                ob.getdeptdetails();
                ob.updatefees();
                ob.results();
                ob.olddisplay();
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
