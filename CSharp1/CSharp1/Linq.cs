using System.Collections.Generic;

namespace CSharp1
{
    class Linq
    {

    }

    public class Book2
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository2
    {
        public IEnumerable<Book2> GetBooks()
        {
            return new List<Book2>
            {
                new Book2() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book2() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book2() {Title = "ASP.NET Web API", Price = 12 },
                new Book2() {Title = "C# Advanced Topics", Price = 7 },
                new Book2() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }

    public class String
    {
        public void Shorten(int numberOfWords)
        {


        }

        public int Add(int a, int b)
        {
            return a + b;
        }


    }

    public class MessageArgs
    {
    }


}
