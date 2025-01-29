using DavidTielke.PersonManagerApp.Data.DataStoring;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Data.FileStoring;
using DavidTielke.PersonManagerApp.Data.FileStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;
using Microsoft.Extensions.DependencyInjection;
using Mappings;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollectionFactory().Create();

            services.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            var provider = services.BuildServiceProvider();

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();
            
            displayCommands.DisplayAllAdults();

            displayCommands.DisplayAllChildren();
        }
    }
}
