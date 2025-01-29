using DavidTielke.PersonManagerApp.UI.ConsoleClient.DataClasses;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}