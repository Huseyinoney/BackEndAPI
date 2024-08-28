using Microsoft.AspNetCore.Http;

namespace BackEndAPI.Application.Services
{
    public interface IKerasEntity
    {
        Task<string> FindEntityFromModelAsync(IFormFile image);
    }
}
