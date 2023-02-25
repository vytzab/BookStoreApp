using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services
{
    internal interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
    }
}