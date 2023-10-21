using AutoMapper;
using DomainLayer.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVM>>
    {
        // Inject repository
        private readonly IBlogRepository _repository;
        private readonly IMapper _mapper;
        public GetBlogQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _repository = blogRepository;
            _mapper = mapper;

        }

        public async Task<List<BlogVM>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllBlogsAsync();
            //var listResult =  result.Select(b => new BlogVM { Name = b.Name, Description = b.Description, Author = b.Author }).ToList();
            var listResult = _mapper.Map<List<BlogVM>>(result);
            return listResult;

        }
    }
}
