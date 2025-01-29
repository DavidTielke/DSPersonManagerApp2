using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Contract;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLine);
}