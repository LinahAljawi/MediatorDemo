using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
	public interface IDataAccess
	{
		List<PersonalModel> GetPeople();
		PersonalModel InsertPerson(string fName, string lName);
	}
}