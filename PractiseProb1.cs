using System;
using System.Collections.Generic;
					
public class Addition
{
	/*public bool Validate(string str)
	{
		int flag = 0, flag2 = 0;
		for(int i = 0; i  < str.Length; i++)
		{
			if(str[i].ToString() == ",")
			{
				flag = 1;
			}
			else if (str[i].ToString() == "\n" && flag == 1)
			{
				flag2 = 0;
			}
			else if (str[i].ToString() == "\n" && flag != 1)
			{
				flag2 = 1;
			}
		}
		
		if(flag2 == 0) return false;
		else return true;
		//return (default);
	}*/
	
	public void AddTheNums(string str)
	{
		//Console.WriteLine(str);
		int sum = 0;
		
		for(int i = 0; i  < str.Length; i++)
		{
			if(str[i].ToString() == "," || str[i].ToString() == "\n")
			{
				//if(str[i].ToString() == "\n") cnt++;
				continue;
			}
			else if(Char.IsDigit(str[i]))
			{
				//Console.Write("inside Else if: ");
				
				sum += (int)Char.GetNumericValue(str[i]);
				
				//Console.WriteLine(sum);
				
				//Console.Write(str[i]);
			}
			//Console.WriteLine(i.ToString());
		}
		Console.WriteLine(sum);
	}
	
	public static void Main()
	{
		Addition obj = new Addition();
		string str = "5\n1,2,3";
		
		//str = Console.ReadLine();
		
		//Console.WriteLine(str);
		
		obj.AddTheNums(str);

		
	}
}
