using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
	public class DemoDataAccess : IDataAccess
	{
		private List<PersonalModel> people = new();

		public DemoDataAccess()
		{
			people.Add(new PersonalModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
			people.Add(new PersonalModel { Id = 2, FirstName = "Linah", LastName = "Aljawi" });
		}

		public List<PersonalModel> GetPeople()
		{
			return people;
		}

		public PersonalModel InsertPerson(string fName, string lName)
		{
			PersonalModel p = new PersonalModel { FirstName = fName, LastName = lName };
			p.Id = people.Max(x => x.Id) + 1;

			people.Add(p);
			return p;
		}
	}
}
