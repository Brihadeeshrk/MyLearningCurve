using System.Collections.Generic;

namespace CSharp1
{
    class LambdaExpressions
    {

    }

    public class Book1
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public List<Book1> GetBooks()
        {
            return new List<Book1>
            {
                new Book1() {Title = "Title 1", Price = 5},
                new Book1() {Title = "Title 2", Price = 7},
                new Book1() {Title = "Title 3", Price = 17}
            };
        }
    }
}
