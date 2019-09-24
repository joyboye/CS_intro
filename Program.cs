using System;

namespace CS_intro1
{
    class Program
    {
        static void Main(string[] args)
        {//  Question 2
            string myProfile1 = "My name is Onom Joy Boye "; 
            var myProfile2 = "I am ";
            int age = 53;
            float output1 = 23.98373f  ;
            float output2 = 5342.987f;
            double doub = 2433.2653 + 82736.233;
            Boolean bool2 = false;
            string concat1 = myProfile1 + " " + myProfile2; // Question 4

            float multi = output1 * output2; // Question 5
            const int num1 = 53;   // Question 6
            const Boolean maritalStatus = true;
            Console.WriteLine("{0},{1} {2} years old ",myProfile1,myProfile2,num1  );  // Question 7

            Console.WriteLine(myProfile1); // Question 3
            Console.WriteLine(myProfile2);
            Console.WriteLine(num1);
            Console.WriteLine(output1);
            Console.WriteLine(doub);
            Console.WriteLine(bool2);
            Console.WriteLine(concat1);
            Console.WriteLine(multi);
            Console.WriteLine(age);
            Console.WriteLine(maritalStatus);









        }
    }
}
