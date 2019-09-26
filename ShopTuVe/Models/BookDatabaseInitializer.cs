using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Dao Quắm"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Dao Đi Rừng"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Roi điện"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Súng Điện"
                }
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "Dao quắm",
                    Description = "Stephen Covey’s cherished classic commemorates the timeless wower of the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="daoquam.jpg",
                    UnitPrice = 850000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "Dao quắm",
                    Description = "Stephen Covey’s cherit.",
                    ImagePath ="1.jpg",
                    UnitPrice = 750000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 3,
                    BookName = "Dao quắm",
                    Description = "Stephen Covey’s cherished classic commemf the 7 Habits b it in a highly readable and understandable, infographics format.",
                    ImagePath ="2.jpg",
                    UnitPrice = 900000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 4,
                    BookName = "Dao quắm",
                    Description = "Stephen Covey’s cherished classic the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="3.jpg",
                    UnitPrice = 750000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 1,
                    BookName = "Dao Đi Rừng",
                    Description = "Stephen Covey’s cherished classier of the 7 Habits bookghly readable and understandable, infographics format.",
                    ImagePath ="ddr1.jpg",
                    UnitPrice = 540000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 2,
                    BookName = "Dao Đi Rừng",
                    Description = "Stephen Covey’s cherished classic commemorates the ti of the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="ddr2.jpg",
                    UnitPrice = 450000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Dao Đi Rừng",
                    Description = "Stephen Covey’s cherished classic commemoratbook, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="ddr3.jpg",
                    UnitPrice = 300000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Dao Đi Rừng",
                    Description = "Stephen Covey’s cherished classic commemorates the timwer of the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="ddr4.jpg",
                    UnitPrice = 600000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 1,
                    BookName = "Roi điện",
                    Description = "Stephen Covey’s cherished claower of the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="r1.jpg",
                    UnitPrice = 200000,
                    CategoryID = 3
                },
                 new Book
                {
                    BookID = 2,
                    BookName = "Roi điện",
                    Description = "Stephen Covey’s cherished classic commemorates its book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="r2.jpg",
                    UnitPrice = 120000,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Roi Điện",
                    Description = "Stephen Covey’s cherished classic commemorates the timele the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="r3.jpg",
                    UnitPrice = 400000,
                    CategoryID = 3
                },
                 new Book
                {
                    BookID = 4,
                    BookName = "Roi Điện",
                    Description = "Stephen Covey’s cherished classic commemorates the timele the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="r4.jpg",
                    UnitPrice = 405000,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 1,
                    BookName = "Súng điện",
                    Description = "Stephen Covey’s cherished classic com does it in a highly readable and understandable, infographics format.",
                    ImagePath ="s1.jpg",
                    UnitPrice = 3000000,
                    CategoryID = 4
                },
                 new Book
                {
                    BookID = 2,
                    BookName = "Súng điện",
                    Description = "Stephen Covey’s cherished classic commemora the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="s2.jpg",
                    UnitPrice = 5000000,
                    CategoryID = 4
                },


            };
            return books;
        }
    }
}