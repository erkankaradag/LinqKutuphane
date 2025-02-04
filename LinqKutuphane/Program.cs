using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinqKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //YAZARLAR LİSTESİ

            List<Author> authors = new List<Author>()
            {
               new Author {AuthorId = 1, AuthorName = "Orhan Pamuk"},
               new Author {AuthorId = 2, AuthorName= "Elif Şafak"},
               new Author {AuthorId = 3, AuthorName= "Ahmet Ümit"}
            };

            // KİTAPLAR LİSTESİ

            List<Book> books = new List<Book>()
            {
                new Book {BookId = 1, Title = "Kar", AuthorId = 1},
                new Book {BookId = 2, Title = "İstanbul", AuthorId = 1},
                new Book {BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2},
                new Book {BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3}
            };

            // KİTAPLAR VE YAZARLAR ARASI JOİN İŞLEMİ

            var query = from author in authors
                        join book in books
                        on author.AuthorId equals book.AuthorId
                        select new
                        {
                            AuthorName = author.AuthorName,
                            BookTitle = book.Title
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"{item.AuthorName} - {item.BookTitle}");
            }


        }
    }
}
