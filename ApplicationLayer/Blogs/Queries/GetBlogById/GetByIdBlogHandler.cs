using ApplicationLayer.Blogs.Queries.GetBlogs;
using AutoMapper;
using DomainLayer.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Queries.GetBlogById
{
    public class GetByIdBlogHandler : IRequestHandler<GetBlogByIdQuery, BlogVM>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public GetByIdBlogHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<BlogVM> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var blogById = await _blogRepository.GetBlogsByIdAsync(request.BlogId);
            var result = _mapper.Map<BlogVM>(blogById);
            return result;
        }
    }
}
