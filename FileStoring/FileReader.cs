namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadLines(string path)
    {
        return File.ReadLines(path);
    }
}