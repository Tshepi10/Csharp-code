using System;

class Program
{
    static void Main(String [] args)
{ 
        string [] names = new string [5];
    names[0] = "Christo";
    names[1] = "Zee";
    names[2] = "Emma";
    names[3] = "Banele";
    names[4] = "Success";

        string [] subj = new string[5];
    subj[0] = "Maths";
    subj[1] = "Economics";
    subj[2] = "Accounting";
    subj[3] = "English";
    subj[4] = "Business Studies";
    
    int [] results = new int[5];
    results[0] = 50;
    results[1] = 65;
    results[2] = 99;
    results[3] = 75;
    results[4] = 98;
    
Console.WriteLine("Student Name:{0} - Subject:{1} - Mark: {2}%", names[0], subj[0],results[0]);

Console.WriteLine("Student Name:{0} - Subject:{1} - Mark: {2}%", names[1], subj[1],results[1]);

Console.WriteLine("Student Name:{0} - Subject:{1} - Mark: {2}%", names[2], subj[2],results[2]);

Console.WriteLine("Student Name:{0} - Subject:{1} - Mark: {2}%", names[3], subj[3],results[3]);

Console.WriteLine("Student Name:{0} - Subject:{1} - Mark: {2}%", names[4], subj[4],results[4]);

}//main method
}//class