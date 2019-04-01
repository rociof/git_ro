/*herencia simple*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    /*la clase base es program y tiene una clase derivada Teacher, con una subclase Student*/
    {

        static void Main(string[] args)
        {
            Teacher d = new Teacher();
            d.Teach();
            /*herencia única: una clase base y una derivada*/

            Student s = new Student();
            s.Learn();
            d.Teach();
            Console.ReadKey();
        }

        class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }

        class Student : Teacher
        {/*Va a tener sus propios métodos y los heredados de la clase padre*/
             public void Learn()
            {
                 Console.WriteLine("Learn");
            }

         }
    }
}
      
   
  
 
 
  
  
J