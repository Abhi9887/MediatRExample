using ApplicationLayer.Comman.Mappings;
using System;
using System.Collections.Generic;
using DomainLayer.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Queries.GetBlogs
{
    public class BlogVM: IMapFrom<Blog>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author {get; set; }  

    }
}
