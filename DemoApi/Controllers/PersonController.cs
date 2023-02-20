using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PersonController : ControllerBase
	{

		private readonly IMediator _mediator;

		public PersonController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<List<PersonalModel>> Get() => await _mediator.Send(new GetPersonListQuery());


		[HttpGet("{id}")]
		public async Task<PersonalModel> Get(int id) => await _mediator.Send(new GetPersonByIdQuery(id));
		

		[HttpPost]
		public async Task<PersonalModel> Post([FromBody] PersonalModel value) => await _mediator.Send(new InsertPersonCommand(value.FirstName, value.LastName));

	}
}
