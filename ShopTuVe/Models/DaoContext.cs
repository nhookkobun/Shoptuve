using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class DaoContext : DbContext
    {
        public DaoContext() : base("ShopTuVe")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dao> Daos { get; set; }

        public DbSet<CartItem> ShoppingCartItems { get; set; }

    }
}