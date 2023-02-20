using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoLibrary.Handlers
{
	internal class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonalModel>
	{

		private readonly IDataAccess _data;

		public InsertPersonHandler(IDataAccess data)
		{
			_data = data;
		}

		public Task<PersonalModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_data.InsertPerson(request.FirstName,request.LastName));
		}
	}
}
