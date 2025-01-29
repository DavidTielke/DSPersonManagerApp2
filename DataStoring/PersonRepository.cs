using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Data.FileStoring.Contract;

namespace DavidTielke.PersonManagerApp.Data.DataStoring;

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