using DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repository
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogsAsync();
        Task<Blog> GetBlogsByIdAsync(int id);
        Task<Blog> CreateBlogsAsync(Blog blogs);
        Task<int> UpdateBlogsAsync(int id, Blog blogs);
        Task<int> DeleteBlogsAsync(int id);

    }
}
