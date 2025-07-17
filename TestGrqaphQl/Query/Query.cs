
using Microsoft.EntityFrameworkCore;
using TestGrqaphQl.Data;
using TestGrqaphQl.Data.Models;

namespace TestGrqaphQl.Query
{
    public class Query
    {
        [UsePaging(IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Book> GetBooks([Service] AppDbContext context) =>
        context.Books.Include(b=>b.Author);

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Author> GetAuthors([Service] AppDbContext context) =>
            context.Authors;
    }

}
