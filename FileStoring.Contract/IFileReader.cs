namespace DavidTielke.PersonManagerApp.Data.FileStoring.Contract;

public interface IFileReader
{
    IEnumerable<string> ReadLines(string path);
}