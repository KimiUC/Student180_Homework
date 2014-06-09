using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //E ovako, ima viška koda i dosta stvari moze biti urađeno puno bolje, ali od mene dosta

            // Read in name
            string error, error1, error2, error3, error4;

            Console.WriteLine("Student 1: ");

            Console.WriteLine("First name: ");
            string input = Console.ReadLine();
            
            Console.WriteLine("Last name: ");
            string input1 = Console.ReadLine();
            
            Console.WriteLine("E-Mail: ");
            string input2 = Console.ReadLine();
            
            Console.WriteLine("Location: ");
            string input3 = Console.ReadLine();
            
            Console.WriteLine("Number of tests: ");
            string input4 = Console.ReadLine();
            
            Student stud = new Student();

            while (!stud.setName(input, out error))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error);
                input = Console.ReadLine();
            }

            while (!stud.setLastName(input1, out error1))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error1);
                input1 = Console.ReadLine();
            }

            while (!stud.setMail(input2, out error2))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error2);
                input2 = Console.ReadLine();
            }

            while (!stud.setLocation(input3, out error3))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error3);
                input3 = Console.ReadLine();
            }

            while (!stud.setResult(input4, out error4))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error4);
                input4 = Console.ReadLine();
            }

            Console.WriteLine("\n\nStudent1 Personal informations are: " + input + ", " + input1 + ", " + input2 + ", " + input3);

            Console.WriteLine("\n");


            //---------------Student2-----------------------------

            Student stud2 = new Student();

            // Read in name
            string error0, error11, error22, error33, error44;

            Console.WriteLine("Student 2: ");

            Console.WriteLine("First name: ");
            string input0 = Console.ReadLine();
            
            Console.WriteLine("Last name: ");
            string input11 = Console.ReadLine();
            
            Console.WriteLine("E-Mail: ");
            string input22 = Console.ReadLine();
            
            Console.WriteLine("Location: ");
            string input33 = Console.ReadLine();

            Console.WriteLine("Number of tests: ");
            string input44 = Console.ReadLine();

            while (!stud2.setName(input0, out error0))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error0);
                input0 = Console.ReadLine();
            }

            while (!stud2.setLastName(input11, out error11))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error11);
                input11 = Console.ReadLine();
            }

            while (!stud2.setMail(input22, out error22))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error22);
                input22 = Console.ReadLine();
            }

            while (!stud2.setLocation(input33, out error33))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error33);
                input33 = Console.ReadLine();
            }

            while (!stud2.setResult(input44, out error44))
            {
                //tells user what is the error and why input is invalid.
                Console.WriteLine("Invalid input: " + error44);
                input44 = Console.ReadLine();
            }

            Console.WriteLine("\n\nStudent2 Personal informations are: " + input0 + ", " + input11 + ", " + input22 + ", " + input33);

            //if (stud.mail == stud2.mail)
            //{
            //    Console.WriteLine("\n\n\nStudent 1 and Student 2 are the same ");
            //}

            if (stud.finalni == stud2.finalni)
            {
                Console.WriteLine("\n\n\nStudent 1 and Student 2 have same final result: ");
            }
            if (stud.finalni != stud2.finalni)
            {
                Console.WriteLine("Student 1 final result: " + stud.finalni);
                Console.WriteLine("Student 2 final result: " + stud2.finalni);
            }

            string stud = stud.mail;
            string stud2 = stud.mail;

            Console.WriteLine("\n\n\n Please enter 'A' or 'a' if you want to check are student1 and student2 equal");
            string jednakost = Console.ReadLine();

            if ((jdnadzba == "a") || (jednadzba == "A"))
            {
            
                if((stud2.CompareResult(stud, stud2)))
                {

                Console.WriteLine("\n\n\nYou enered same students");

                }
                else
                {
                    Console.WriteLine("\n\n\nYou enered different students");

                }
            }

            Console.ReadLine();

        }

    }
}
