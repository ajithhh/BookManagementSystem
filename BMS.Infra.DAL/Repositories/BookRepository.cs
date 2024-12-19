﻿namespace BMS.Infra.DAL.Repositories
{
    using BMS.Core.Entities;
    using BMS.Core.Interfaces;
    using Microsoft.EntityFrameworkCore;


    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync() => await _context.Books.ToListAsync();
        public async Task<Book?> GetBookByIdAsync(int id) => await _context.Books.FindAsync(id);
        public async Task AddBookAsync(Book book) { _context.Books.Add(book); await _context.SaveChangesAsync(); }
        public async Task UpdateBookAsync(Book book) { _context.Books.Update(book); await _context.SaveChangesAsync(); }
        public async Task DeleteBookAsync(int id) { var book = await _context.Books.FindAsync(id); if (book != null) _context.Books.Remove(book); await _context.SaveChangesAsync(); }
    }
}