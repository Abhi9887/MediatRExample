using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.CreateBlog
{
    public  class CreateBlogCommadnValidator : AbstractValidator<CreateBlogCommand>
    {
        public CreateBlogCommadnValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required").MinimumLength(2);
            RuleFor(x => x.Description).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Author).NotEmpty().WithMessage("Name is required");
        }
    }
}
