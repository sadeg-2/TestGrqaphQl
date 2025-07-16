using Microsoft.EntityFrameworkCore;
using TestGrqaphQl.Data;
using TestGrqaphQl.Data.Models;

namespace TestGrqaphQl.Mutations
{
    public class Mutation
    {
        public async Task<Book> UpdateBook(Book input, [Service] AppDbContext context)
        {
            var book = await context.Books.FirstOrDefaultAsync(b => b.Id == input.Id);

            if (book == null)
                throw new GraphQLException("Book not found.");

            book.Title = input.Title;
            book.AuthorId = input.AuthorId;
            await context.SaveChangesAsync();
            var author = await context.Authors.FirstOrDefaultAsync(author => author.Id == book.AuthorId);
            book.Author = author; 
            return book;
        }
        public async Task<Author> AddAuthor(string name, [Service] AppDbContext context)
        {
            var author = new Author { Name = name };
            context.Authors.Add(author);
            await context.SaveChangesAsync();
            return author;
        }

        public async Task<Book> AddBook(string title, int authorId, [Service] AppDbContext context)
        {
            var author = await context.Authors.FindAsync(authorId);
            if (author == null)
                throw new GraphQLException("Author not found");

            var book = new Book { Title = title, AuthorId = authorId };
            context.Books.Add(book);
            await context.SaveChangesAsync();
            
            return book;
        }

    }

}
