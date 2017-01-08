//Mike's Read Method, used to read "single" characters info from Console. 
using System;
using System.Text;

namespace ReadIt
{
	class ReadIt
	{
		public static void Main(string[] args)
		{
			StringBuilder Input = new StringBuilder();
			int ival;
			char ch = ' ';
			
			Console.WriteLine("Enter text. When done, press CTRL+Z:");
			
			//while loop is used to read characters.
			while (true) 
			{
				ival = Console.Read(); //does the actual read, and value read is placed in the ival variable.
				if ( ival == - 1 )     //If ival is equal to -1, the end of the input has been reached and a break command is used to get out of the while loop.
					break;
				ch = ( char ) ival;    //If the ival character is valid, this numeric value is cast to a character value in Line 23. 
				
				Input.Append(ch);  // The character value is then appended to the string Input.
			}

			Console.WriteLine("\n\n==========>\n");
			Console.Write( Input );  //prints the full value of the Input string. All the characters were stored, in addition to the carriage returns and line feeds.
			Console.Write("\n\n");   
			
			Console.ReadKey(true); //pause.
		}
	}
}