using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Models;

namespace BookApi.Repositories
{
    public interface IBooksRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Add(Book book);
        Task Delete(int id);
        Task Update(Book book);
    }
}
