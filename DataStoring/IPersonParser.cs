using DavidTielke.PersonManagerApp.UI.ConsoleClient.DataClasses;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLine);
}