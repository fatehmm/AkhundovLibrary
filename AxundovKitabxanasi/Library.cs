using System;
namespace AxundovKitabxanasi
{
	public class Library
	{
		public Library()
		{
		}
		public Book[] books = new Book[0];

		public static Book[] AddBook(ref Book[] books , Book book)
        {
			Array.Resize(ref books, books.Length + 1);
			books[books.Length - 1] = book;
			return books;
        }
	}
}

