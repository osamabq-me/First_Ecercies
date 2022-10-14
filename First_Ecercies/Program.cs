using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Ecercies
{
    class Program
    {
        //Create array
         int[] OSS = new int[27];
        //Create Count
        int n;
        //Create A user input 
        public void Userinput()
        {
            //while loop to check if the enterd number follow the roles 
            while (true)
            {
                Console.WriteLine(" Enter your wanted number of elements");
                String s = Console.ReadLine();
                n = Int32.Parse(s);
                //if loop to decied if it coorect or no
                if (n <= 27)
                    break;
                else
                    Console.WriteLine("Maximam elements number is 27");
            }
            Console.Clear();
            //Loop to enter elements to array
            Console.WriteLine("==========================");
            Console.WriteLine("   Enter the elements");
            Console.WriteLine("==========================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                OSS[i] = Int32.Parse(s1);
            }


            Console.Clear();
            //display the Unorganised elements
            Console.WriteLine("==========================");
            Console.WriteLine("  Unorganised elements");
            Console.WriteLine("==========================");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(OSS[j]);
            }
            Console.ReadKey();

        }
        public void Display()
        {
            //display the organised elements
            Console.WriteLine("======================");
            Console.WriteLine("  Organised elements");
            Console.WriteLine("======================");
            for (int OA = 0; OA < n; OA++)
            {
                Console.WriteLine(OSS[OA]);
            }
            Console.ReadKey();
        }
        public void orgniser()
        {
            int minindex;
            for (int i = 0; i < n-2; i++)
            {
                minindex = i;
                int OA;
                
                for (OA = 0; OA < n - i; OA++)
                {


                    if (OSS[OA] <OSS[minindex])
                    {
                        minindex = i;
                    }
                    else;
                   
                }
                int temp;
                temp = OSS[OA];
                OSS[OA] = OSS[minindex];
                OSS[minindex] = temp;

            }






        }

        static void Main(string[] args)
        {
            Program MyList = new Program();
            MyList.Userinput();
            MyList.orgniser();
            MyList.Display();
            Console.WriteLine("\n\n Prees any key to exit.");
            Console.Read();



        }
    }
}






