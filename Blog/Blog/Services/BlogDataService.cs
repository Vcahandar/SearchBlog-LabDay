using Blog.Data;
using Blog.Models;
using Blog.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Blog.Services
{
    public class BlogDataService : IBlogDataService
    {
        private readonly AppDbContext _context;
        public BlogDataService(AppDbContext context)
        {
                _context=context;
        }

        public async Task<List<BlogData>> GetAllAsync()
        {
            return await _context.BlogDatas.ToListAsync();
        }

        public async Task<List<BlogData>> GetBlogsBySearchTextAsync(string searchText)
        {
            if(searchText == null)
            {
                return await _context.BlogDatas.ToListAsync();
            }


            return await _context.BlogDatas.Where(m => m.Title.ToLower().Contains(searchText.ToLower())).ToListAsync();
        }

        public async Task<BlogData> GetByIdAsync(int? id)
        {
            return await _context.BlogDatas.FirstOrDefaultAsync(m => m.Id == id);
        }


    }
}
