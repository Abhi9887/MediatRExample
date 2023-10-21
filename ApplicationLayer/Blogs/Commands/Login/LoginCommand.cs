using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.Login
{
    public record class LoginCommand(string email, int password) : IRequest<int>;
}
