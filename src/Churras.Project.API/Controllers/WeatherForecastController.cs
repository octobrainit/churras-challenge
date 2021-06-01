using Churras.Project.Domain.Commands.v1.CriarChurrasco;
using Churras.Project.Shared.Domain.Classes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Churras.Project.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<EventResponse<Domain.Entities.v1.Churrasco>> Get()
        {
            return await _mediator.Send(new CriarChurrascoCommand { Data = DateTime.Now, ValorSugerido = 126.50 });
        }
    }
}
