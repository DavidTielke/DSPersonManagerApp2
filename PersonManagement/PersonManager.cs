using DavidTielke.PersonManagerApp.UI.ConsoleClient.DataClasses;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

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