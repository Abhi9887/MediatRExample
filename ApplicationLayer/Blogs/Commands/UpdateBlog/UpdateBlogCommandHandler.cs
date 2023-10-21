using DomainLayer.Entity;
using DomainLayer.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
    {
        private readonly IBlogRepository _blogRepository;
        public UpdateBlogCommandHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEntity = new Blog()
            {
                Id = request.Id,
                Author = request.Author,
                Name = request.Name,
                Description = request.Description
            };
            return await _blogRepository.UpdateBlogsAsync(request.Id, blogEntity);
        }
    }
}
