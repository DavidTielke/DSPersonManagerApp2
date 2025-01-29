using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _personRepository;

    public PersonManager(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _personRepository.Query().Where(p => p.Age >= 18);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _personRepository.Query().Where(p => p.Age < 18);
    }
}