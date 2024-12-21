using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Data
{
    public class BookShopContext : DbContext
    {
        public BookShopContext(DbContextOptions<BookShopContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
