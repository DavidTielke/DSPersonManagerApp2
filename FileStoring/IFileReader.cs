namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}