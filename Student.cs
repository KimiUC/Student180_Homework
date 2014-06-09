using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Student
    {
        
        //----------------First Name--------------------
        internal bool setName(string name, out string errorMsg)
        {

            //check if name is empty or null

            if (name == "" || name == " " || name == null)
            {

                errorMsg = "Name can not be empty or null, please enter the first name ";
                return false;

            }

            //check that name is 2 chars long 
            if (name.Length < 2)
            {
                errorMsg = "Name has to be at least 2 characters long, please enter First name again ";
                return false;
            }


            //check that name has vowel or x 
            if ((!name.Contains('a')) && (!name.Contains('e')) && (!name.Contains('i')) && (!name.Contains('o')) && (!name.Contains('u')) && (!name.Contains('x')))
            {

                errorMsg = "First Name must contain Vowel or x, please enter First name again ";
                return false;
            }

            //convert string to array of characters
            char[] nameCharArray = name.ToCharArray();

            

            //check first character is uppercase
            char firstChar = name.ToCharArray()[0];

            if (!char.IsUpper(firstChar))
            {
                errorMsg = "Name has to start with uppercase letter, please enter First name again ";
                return false;
            }


            for (int i = 1; i < name.Length; ++i)
            {
                char otherChars = name.ToCharArray()[i];

                //Can not contain numbers
                if (char.IsNumber(otherChars))
                {
                    errorMsg = " Name can not contain numbers, please enter First name again ";
                    return false;
                }

                //All characters except first character must be in lowercase
                else if (!char.IsLower(otherChars))
                {
                    errorMsg = "Name need to have lowercase letters exept first one, please enter First name again ";
                    return false;
                }

                //Name can not have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg = "Name can not have special characters, please enter First name again ";
                    return false;
                }

            }

            errorMsg = "";
            return true;
        }





        //------------------------Second Name---------------------------------------
        internal bool setLastName(string name1, out string errorMsg1)
        {

            //check if name is empty or null

            if (name1 == "" || name1 == " " || name1 == null)
            {

                errorMsg1 = "Name can not be empty or null, please enter Last name ";
                return false;

            }

            //check that name is 2 chars long 
            if (name1.Length < 2)
            {
                errorMsg1 = "Name has to be at least 2 characters long, please enter Last name again ";
                return false;
            }


            //check that name has vowel or x 
            if ((!name1.Contains('a')) && (!name1.Contains('e')) && (!name1.Contains('i')) && (!name1.Contains('o')) && (!name1.Contains('u')) && (!name1.Contains('x')))
            {

                errorMsg1 = "Name must contain Vowel or x, please enter Last name again ";
                return false;
            }

            //convert string to array of characters
            char[] nameCharArray = name1.ToCharArray();

            //check that Name contains Only letters. Numbers, spaces, special characters etc. are not allowed
            //"Name must contain only letters. Numbers, spaces, special characters etc. are not allowed"

            //check first character is uppercase
            char firstChar = name1.ToCharArray()[0];

            if (!char.IsUpper(firstChar))
            {
                errorMsg1 = "Name has to start with uppercase letter, please enter Last name again ";
                return false;
            }


            for (int i = 1; i < name1.Length; ++i)
            {
                char otherChars = name1.ToCharArray()[i];

                //Can not contain numbers
                if (char.IsNumber(otherChars))
                {
                    errorMsg1 = "Name cant have numbers, please enter Last name again ";
                    return false;
                }

                //All characters except first character must be in lowercase
                else if (!char.IsLower(otherChars))
                {
                    errorMsg1 = "Name need to have lowercase letters, exept first one, please enter Last name again ";
                    return false;
                }

                //Name can not have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg1 = "Name can not have special character, please enter Last name again ";
                    return false;
                }

            }

            errorMsg1 = "";
            return true;
        }





        public string mail;

        //---------------------------Email-------------------------------------
        internal bool setMail(string name2, out string errorMsg2)
        {

            //NOW check if mail is empty or null

            if (name2 == "" || name2 == " " || name2 == null)
            {

                errorMsg2 = "E-Mail can not be empty or null, please enter Mail";
                return false;

            }

            //check that E-mail is 5 chars long 
            if (name2.Length < 5)
            {
                errorMsg2 = "E-Mail need to be at least 5 characters long, please enter Mail again ";
                return false;
            }


            //check that E-mail has @ or dot 
            if ((!name2.Contains('@')))
            {

                errorMsg2 = "E-Mail must contain @ sign, please enter Mail again";
                return false;
            }



            //Check if E-mail has .com, ba or edu domain
            if ((!name2.EndsWith(".com")) && (!name2.EndsWith(".ba")) && (!name2.EndsWith(".edu")) && (!name2.EndsWith(".edu.ba")))
            {

                errorMsg2 = "E-Mail must contain .com, .ba, .edu or .edu.ba domain, please enter Mail again ";
                return false;
            }
            //convert string to array of characters
            //char[] nameCharArray = name2.ToCharArray();

            //check that Name contains Only letters. Numbers, spaces, special characters etc. are not allowed
            //"Name must contain only letters. Numbers, spaces, special characters etc. are not allowed"


            //char firstChar = name2.ToCharArray()[0];

            mail = name2;

            errorMsg2 = "";
            return true;
        }


        



        //----------------------Location-----------------------------------
        internal bool setLocation(string name3, out string errorMsg3)
        {

            //check if location is empty or null

            if (name3 == "" || name3 == " " || name3 == null)
            {

                errorMsg3 = "Location can not be empty or null, please enter Location";
                return false;

            }

            //check that location is 2 chars long 
            if (name3.Length < 2)
            {
                errorMsg3 = "Location has to be at least 2 characters long, please enter Location again ";
                return false;
            }


            //check that location has vowel or x 
            if ((!name3.Contains('a')) && (!name3.Contains('e')) && (!name3.Contains('i')) && (!name3.Contains('o')) && (!name3.Contains('u')) && (!name3.Contains('x')))
            {

                errorMsg3 = "Location must contain Vowel or x, please enter Location again ";
                return false;
            }

            //convert string to array of characters
            char[] nameCharArray = name3.ToCharArray();


            //check if first character is uppercase
            char firstChar = name3.ToCharArray()[0];

            if (!char.IsUpper(firstChar))
            {
                errorMsg3 = "Location has to start with uppercase letter, please enter Location again ";
                return false;
            }


            for (int i = 1; i < name3.Length; ++i)
            {
                char otherChars = name3.ToCharArray()[i];



                //All characters except first one must be in lowercase
                if (!char.IsLower(otherChars))
                {
                    errorMsg3 = "Location need to have lowercase letters, exept first one, please enter Location again";
                    return false;
                }

                //Location can not have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg3 = "Location can not have special characters";
                    return false;
                }

            }

            errorMsg3 = "";
            return true;
        }


        public double final;


        //----------------------Result---------------------------------
        internal bool setResult(string name4, out string errorMsg4)
        {

            //check if result is empty or null

            if (name4.ToString() == "" || name4.ToString() == " " || name4.ToString() == null)
            {

                errorMsg4 = "Test Result can not be empty or null, if student did not work test please enter -1";
                return false;

            }


            //convert string to array of characters
            char[] nameCharArray = name4.ToCharArray();

            //check that Name contains Only letters. Numbers, spaces, special characters etc. are not allowed
            //"Name must contain only letters. Numbers, spaces, special characters etc. are not allowed"

            char firstChar = name4.ToCharArray()[0];




            for (int i = 1; i < name4.Length; ++i)
            {
                char otherChars = name4.ToCharArray()[i];

                //Can not contain letters
                if (char.IsLetter(otherChars))
                {
                    errorMsg4 = "result can not have letters";
                    return false;
                }


                //Can not have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg4 = "Result cant have special characters";
                    return false;
                }

            }

            //Console.WriteLine("Enter number of tests: ");
            //string input4 = Console.ReadLine();

            //setResult(input4);

            double[] arr = new double[10];
            int[] ukupno = new int[10];

            for (int a = 1; a <= Convert.ToInt32(name4); ++a)
            {

                Console.WriteLine("Enter Grade for test " + a + ": ");

                try
                {
                    arr[k] = Convert.ToDouble(Console.ReadLine());
                    //ukupno[a] += arr[a];

                }
                catch
                {
                    Console.WriteLine("You enterd letters insted of numbers");
                    break;
                }


            }

            Console.WriteLine("\n\n\n Student test results: ");

            for (int x = 1; x <= Convert.ToInt32(name4); x++)
            {
                Console.WriteLine("\n Results for test" + x + " are: {0} ", arr[x]);
            }

            finalni = arr.Sum() / Convert.ToDouble(name4);

            Console.WriteLine("\n\n   Total score is " + final);
            errorMsg4 = "";
            return true;
        }
        


        //Checking are students equal by E-mail


       public bool CompareResult(string Email, string Email2)
        {
            if (Email == Email2)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
