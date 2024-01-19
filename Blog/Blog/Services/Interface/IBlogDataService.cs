using Blog.Models;

namespace Blog.Services.Interface
{
    public interface IBlogDataService
    {
        Task<List<BlogData>> GetBlogsBySearchTextAsync(string searchText);
        Task<List<BlogData>> GetAllAsync();
        Task<BlogData> GetByIdAsync(int? id);

    }
}
