using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Authors;

namespace BookStoreApp.API.Repositories
{
    public interface IAuthorsRepository : IGenericRepository<Author>
    {
        Task<AuthorDetailsDto> GetAuthorDetailsAsync(int id);
    }
}