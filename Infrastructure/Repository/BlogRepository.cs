using DomainLayer.Entity;
using DomainLayer.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DataContext _dbContext;
        public BlogRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Blog> CreateBlogsAsync(Blog blogs)
        {
           _dbContext.Blogs.Add(blogs);
            await _dbContext.SaveChangesAsync();
            return blogs;
        }

        public async Task<int> DeleteBlogsAsync(int id)
        {
            return await _dbContext.Blogs.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            return await _dbContext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetBlogsByIdAsync(int id)
        {
            return await _dbContext.Blogs.FirstAsync(x => x.Id == id);
        }

        public async Task<int> UpdateBlogsAsync(int id, Blog blogs)
        {
            return await _dbContext.Blogs.Where(c=> c.Id == id).ExecuteUpdateAsync(sett => sett.
            SetProperty(c=> c.Name , blogs.Name)
            .SetProperty(c=> c.Author , blogs.Author).SetProperty(c=> c.Description,blogs.Description));
        }
    }
}
