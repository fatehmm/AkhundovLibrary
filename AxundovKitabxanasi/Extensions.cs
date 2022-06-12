using System;
namespace AxundovKitabxanasi
{
	public static class Extensions
	{

		public static string Capitalize(this string word)
		{
			word = word.ToLower();
			word = char.ToUpper(word[0]) + word.Substring(1);
			return word;

		}
	}
}

