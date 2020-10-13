using MyBookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookStoreApp.Repository
{
    public class BookRepository
    {
        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel{Id=1,Name="MVC",Author="Harshad1"},
                new BookModel{Id=2,Name="WebAPI",Author="Harshad2"},
                new BookModel{Id=3,Name="Angular",Author="Harshad3"},
                new BookModel{Id=4,Name="Node",Author="Harshad4"},
                new BookModel{Id=5,Name="React",Author="Harshad5"},

            };
        }
        public List<BookModel> GetAllBooks()
        {
            return this.DataSource().ToList();
        }
        public BookModel GetBook(int id)
        {
            return this.DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string bookName, string author)
        {

            return this.DataSource().Where(x => x.Name == bookName || x.Author == author).ToList();

        }
    }
}
