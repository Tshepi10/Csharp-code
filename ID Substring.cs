using System;
using System.IO;

class Program
{
    static void Main(string [] args)
    {
   Console.WriteLine("Enter ID Number");
   string ID = Console.ReadLine();

   string first13 =ID.Substring(0,13);

   string gender = first13.Substring(10,3);
   int gen = Convert.ToInt16(gender);


   string first6 =ID.Substring(0,6);

   string year = first6.Substring(0,2);
   Console.WriteLine("Year of Birth {0}",year);

   string month = first6.Substring(2,2);
   int mnth = Convert.ToInt16(month);
   Console.WriteLine("Month of Birth {0}",month);

   string day = first6.Substring(4,2);
   Console.WriteLine("Day of Birth {0}",day); 


   if(gen == 081)
   {
    Console.WriteLine("Gender: Female");

   }
   else if(gen == 082)
   {
    Console.WriteLine("Gender: Male");
   }
    

   switch(mnth)
            {
            case 01 : Console.WriteLine("Your birthday is on {0} January {1}", day, year); break;
            case 02 : Console.WriteLine("Your birthday is on {0} February {1}", day, year); break;
            case 03 : Console.WriteLine("Your birthday is on {0} March {1}", day, year); break;
            case 04 : Console.WriteLine("Your birthday is on {0} April {1}", day, year); break;
            case 05 : Console.WriteLine("Your birthday is on {0} May {1}", day, year); break;
            case 06 : Console.WriteLine("Your birthday is on {0} June {1}", day, year); break;
            case 07 : Console.WriteLine("Your birthday is on {0} July {1}", day, year); break;
            case 08 : Console.WriteLine("Your birthday is on {0} August {1}", day, year); break;
            case 09 : Console.WriteLine("Your birthday is on {0} September {1}", day, year); break;
            case 10 : Console.WriteLine("Your birthday is on {0} October {1}", day, year); break;
            case 11 : Console.WriteLine("Your birthday is on {0} November {1}", day, year); break;
            case 12 : Console.WriteLine("Your birthday is on {0} December {1}", day, year); break;
            }
    }//main method

}//class


