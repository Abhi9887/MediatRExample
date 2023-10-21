using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Queries.GetBlogs
{
    public class GetBlogQuery : IRequest<List<BlogVM>>
    {


    }


    // new way 

    //public record GetBlogQuery : IRequest<List<BlogVM>>;
}
