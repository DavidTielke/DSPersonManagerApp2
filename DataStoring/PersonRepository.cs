using DavidTielke.PersonManagerApp.UI.ConsoleClient.DataClasses;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

public class PersonRepository : IPersonRepository
{
    private readonly IFileReader _fileReader;
    private readonly IPersonParser _personParser;

    public PersonRepository(IFileReader fileReader, 
        IPersonParser personParser)
    {
        _fileReader = fileReader;
        _personParser = personParser;
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _fileReader.ReadLines("data.csv");
        var persons = dataLines.Select(_personParser.ParseFromCsv);
        return persons.AsQueryable();
    }
}