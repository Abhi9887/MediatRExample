using ApplicationLayer.Blogs.Commands.CreateBlog;
using ApplicationLayer.Blogs.Queries.GetBlogById;
using ApplicationLayer.Blogs.Queries.GetBlogs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : APIControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var blogs = await Medior.Send(new GetBlogQuery());
            return Ok(blogs);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdAync(int id)
        {
           var blog = await Medior.Send(new GetBlogByIdQuery() { BlogId = id});
            if(blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCommand command)
        {
            var createdBlogResult = await Medior.Send(command);
            return Ok(createdBlogResult);
        }

    }
}
