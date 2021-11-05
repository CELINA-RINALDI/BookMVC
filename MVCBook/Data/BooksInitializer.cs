using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBook.Data
{
    public class BooksInitializer: DropCreateDatabaseAlways<BookDbContext>
    {
        protected override void Seed(BookDbContext context)
        {
            var books = new List<Book>
            {
                new Book
                {
                    Name="Peter Pan",
                    Author = "James M. Barrie",
                    PagesNumber = 50,
                    Publisher = "Start Publishing",
                    PublicationDate = "12/9/2014",
                    Content = "For child",
                    Price = 500,
                    PriceConfirm = 500

                }

            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
        }
    }
}