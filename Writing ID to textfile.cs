using System;
using System.IO;

class Program
{
    static void Main(string [] args)
    {

       string filepath = "details.txt";

       using(StreamWriter sw = new StreamWriter(filepath))
        {

        Console.WriteLine("Enter 13 Digit ID Number:");
        string id = Console.ReadLine();
	

        sw.WriteLine(id);

        string first6 = id.Substring(0,6);

        int year = Convert.ToInt16(first6.Substring(0,2));

        string y = first6.Substring(0,2);
        sw.WriteLine("Year of Birth {0}",y);

        string month = first6.Substring(2,2);
        int mnth = Convert.ToInt16(month);
        sw.WriteLine("Month of Birth {0}",month);

        string day = first6.Substring(4,2);
        sw.WriteLine("Day of Birth {0}",day);

        string yr = year + " ";

        if(year >= 0 && year <=23)
        {
            yr = "20" + "0" + year;
        }
        else if(year <= 99)
        {
            yr = "19"+ year;
        }
       
       sw.WriteLine("Your birthday is {0}/{1}/{2}",day,month,y);

    

       switch(mnth)
            {
            case 01 : sw.WriteLine("Your birthday is on {0} January {1}", day, yr); break;
            case 02 : sw.WriteLine("Your birthday is on {0} February {1}", day, yr); break;
            case 03 : sw.WriteLine("Your birthday is on {0} March {1}", day, yr); break;
            case 04 : sw.WriteLine("Your birthday is on {0} April {1}", day, yr); break;
            case 05 : sw.WriteLine("Your birthday is on {0} May {1}", day, yr); break;
            case 06 : sw.WriteLine("Your birthday is on {0} June {1}", day, yr); break;
            case 07 : sw.WriteLine("Your birthday is on {0} July {1}", day, yr); break;
            case 08 : sw.WriteLine("Your birthday is on {0} August {1}", day, yr); break;
            case 09 : sw.WriteLine("Your birthday is on {0} September {1}",day, yr); break;
            case 10 : sw.WriteLine("Your birthday is on {0} October {1}", day, yr); break;
            case 11 : sw.WriteLine("Your birthday is on {0} November {1}", day, yr); break;
            case 12 : sw.WriteLine("Your birthday is on {0} December {1}", day, yr); break;
       
             }//sw
        }
        
       using(StreamReader sr = new StreamReader(filepath))
       {
    	string line;
	Console.WriteLine("Reading file : {0}",filepath);
	
	while((line = sr.ReadLine()) !=null)
	{
		Console.WriteLine(line);
    }

	Console.WriteLine("Read file {0} complete!", filepath);
	
       }   


    
    }//main method
}//class


        


