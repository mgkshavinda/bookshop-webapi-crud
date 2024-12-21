using BookShopAPI.Data;
using BookShopAPI.Models;

namespace BookShopAPI.Service
{
    public class BookService : IBookService
    {
        private readonly BookShopContext _context;

        public BookService(BookShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks() => _context.Books.ToList();

        public Book GetBookById(int id) => _context.Books.Find(id);

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
