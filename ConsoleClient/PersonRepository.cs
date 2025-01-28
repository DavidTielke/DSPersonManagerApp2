namespace ConsoleClient;

class PersonRepository
{
    private readonly FileReader _fileReader;
    private readonly PersonParser _personParser;

    public PersonRepository()
    {
        _fileReader = new FileReader();
        _personParser = new PersonParser();
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _fileReader.ReadLines("data.csv");
        var persons = dataLines.Select(_personParser.ParseFromCsv);
        return persons.AsQueryable();
    }
}