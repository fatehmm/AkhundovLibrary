using System;
namespace AxundovKitabxanasi
{
	public class Book
	{
		public Book()
		{
			TotalCounter++;
			_identifierAccess = TotalCounter;
		}

		private static int TotalCounter = 0;
		private int _identifierAccess;

		public int IdentifierAccess
        {
            get
            {
				return _identifierAccess;
            }
        }
		public string Name;
		public string Genre;
		public string Author;
		public double Price;
	}
}

