using System;
using System.IO;

class Program
{
 	static void Main(string [] args)
	{
		string filepath = "emmatestfile.txt";
		
		using(StreamWriter writer = new StreamWriter(filepath))
{
	writer.WriteLine("My name is emma");
	writer.WriteLine("I am 23 years old");
	witer.WriteLine("My favourite colour is nude");
}

	using(StreamReader reader = new StreamWriter(filepath))
{
	string line;
	Console.WriteLine("Reading from the file: {0}", filepath);
	
	while((line = reader.ReadLine()) !=null)
	{
	Console.WriteLine(line);
}
Console.WriteLine(File Operations completed.");
}
}//main method
}//class



        


