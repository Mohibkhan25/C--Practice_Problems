using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		string[] dataItems = { string.Empty, "data", "", "hello" };
		
		foreach(string item in dataItems)
		{
			if(StringValidatorLib.StringValidator.IsEmpty(item))
			{
				Console.WriteLine("Invalid string : {0} ", item);
			}
		}
	}
}
