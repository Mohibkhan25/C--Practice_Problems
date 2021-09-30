using System;
 
namespace StringValidatorLib
{
	public class StringValidator
	{
		public static bool IsEmpty(string item)
		{
			return item == string.Empty ? true : false;
		}
		public static bool IsNull(string item)
		{
			return item == null ? true : false;
		}
	}
}
