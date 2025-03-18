using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagerApi.Data;
using BookManagerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagerApi.Routes
{
    public static class BookRoute
    {
        public static void BookRoutes(WebApplication app)
        {
            var route = app.MapGroup("book");

            route.MapPost("", async (BookRequest req, BookDbContext context) =>
            {
                try
                {
                    var book = new BookModel(req.Nome, req.Genero, req.Autor);
                    await context.AddAsync(book);
                    await context.SaveChangesAsync();
                    return Results.Created($"{book.Id}", book);                    
                }
                catch (DbUpdateException e)
                {
                    return Results.BadRequest($"Erro ao criar um novo livro: {e.Message}");
                }
                catch (Exception)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
            });

            route.MapGet("", async (BookDbContext context) =>
            {
                var books = await context.Books.ToListAsync();
                return Results.Ok(books);
            });

            route.MapGet("{guid:id}", async (Guid id, BookDbContext context) =>
            {   
                var book = await context.Books.FindAsync(id);

                if (book == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(book);
            });

            
        }
    }
}