using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class APIControllerBase : ControllerBase
    {
        private ISender _mediatR;

        protected ISender Medior => _mediatR ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
