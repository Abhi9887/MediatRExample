using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Blogs.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, int>
    {
        public LoginCommandHandler()
        {
            
        }
        public Task<int> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
