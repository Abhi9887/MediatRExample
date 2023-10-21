using AutoMapper;
using DomainLayer.Entity;
using DomainLayer.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, string>
    {
        //Inject Dependency
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEntity = new Blog() { Author = request.Author, Description = request.Description, Name = request.Name };
            await _blogRepository.CreateBlogsAsync(blogEntity);
            return "Created Successfully";
        }
    }
}
