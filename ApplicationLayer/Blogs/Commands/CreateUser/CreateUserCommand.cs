using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.CreateUser
{
    public record class CreateUserCommand(string name,string email, string passwoord) :IRequest<string>;
}
