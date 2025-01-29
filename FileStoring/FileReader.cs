using DavidTielke.PersonManagerApp.Data.FileStoring.Contract;

namespace DavidTielke.PersonManagerApp.Data.FileStoring;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadLines(string path)
    {
        return File.ReadLines(path);
    }
}