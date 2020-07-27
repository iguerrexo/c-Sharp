using System;
using System.Collections.Generic;

namespace Lab_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //access returnType name (type1 parm1, type 2 param2)

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 567, 123, 78, 16, 723, 10, 135, 2, 46, 78 };
            new Program().HomeWork(nums);

        }
        public void HomeWork(List<int> numbers)
        {
            System.Console.WriteLine("this is the solution");
            // 1 - print the sum of all numbers
       
            // 3 - print Only even numbers ( % )
          int i,n,sum=0;
   
	Console.Write("\n\n");
    Console.Write("Calculate n terms of even natural number and their sum:\n");
    Console.Write("---------------------------------------------------------");
    Console.Write("\n\n");   

   Console.Write("Input number of terms : ");
   n= Convert.ToInt32(Console.ReadLine());    
   Console.Write("\nThe even numbers are :");
   for(i=1;i<=n;i++)
   {
     Console.Write("{0} ",2*i);
     sum+=2*i;
   }
   Console.Write("\nThe Sum of even Natural Number upto {0} terms : {1} \n",n,sum);
 }
} 


        }

        void Variables()
        {
            string noVal;
            string fName = "Nora";
            int age = 20;
            decimal d = 99.98m;
            float f = 99.98f;
            bool found = true;

            Console.WriteLine("_____________");
            System.Console.WriteLine(age + 1);
            System.Console.WriteLine(age - 10);
            System.Console.WriteLine(age * 10);
            System.Console.WriteLine(age / 2);
            System.Console.WriteLine(age % 2);

            for (int i = 0; i < 10; i++)
            {
                if (i != 5 && i != 7)
                {
                    System.Console.WriteLine(i);
                }
            }

            // Print the numbers from 20 to zero
            for (int j = 20; j > -1; j--)
            {
                System.Console.WriteLine(j);

            }

            // Arrays
            string[] students = new string[50];
            students[0] = "Student 1";
            students[1] = "another";

            // List
            List<string> animals = new List<string>();
            animals.Add("Lion");
            animals.Add("Tiger");

            string first = animals[0];

            for (int k = 0; k < animals.Count; k++)
            {
                System.Console.WriteLine(animals[k]);
            }

        }
    }
}

//dotnet watch run (start terminal)
