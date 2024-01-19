using Blog.Data;
using Blog.Models;
using Blog.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogDataService _blogDataService;
        private readonly AppDbContext _appDbContext;
        public HomeController(IBlogDataService blogDataService,AppDbContext appDbContext)
        {
            _blogDataService= blogDataService;
                _appDbContext= appDbContext;
        }
        public async Task<IActionResult> Index(string searchText)
        {
            List<BlogData> blogDatas =  await _blogDataService.GetBlogsBySearchTextAsync(searchText);
            return View(blogDatas);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var dbBlog = await _blogDataService.GetByIdAsync(id);
            return View(dbBlog);
        }



    }
}