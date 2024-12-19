namespace BMS.Application.Services
{
    using AutoMapper;
    using BMS.Application.DTOs;
    using BMS.Application.Interfaces;
    using BMS.Core.Interfaces;

    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var books = await _repository.GetAllBooksAsync();
            return _mapper.Map<List<Book>>(books);
        }

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            var book = await _repository.GetBookByIdAsync(id);
            return _mapper.Map<Book>(book);
        }

        public async Task AddBookAsync(Book bookDto)
        {
            var book = _mapper.Map<Core.Entities.Book>(bookDto);
            await _repository.AddBookAsync(book);
        }

        public async Task UpdateBookAsync(Book bookDto)
        {
            var book = _mapper.Map<Core.Entities.Book>(bookDto);
            await _repository.UpdateBookAsync(book);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _repository.DeleteBookAsync(id);
        }
    }
}