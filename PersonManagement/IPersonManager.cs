using DavidTielke.PersonManagerApp.UI.ConsoleClient.DataClasses;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}