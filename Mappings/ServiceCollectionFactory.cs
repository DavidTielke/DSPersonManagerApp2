using DavidTielke.PersonManagerApp.Data.DataStoring;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Data.FileStoring;
using DavidTielke.PersonManagerApp.Data.FileStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;
using DavidTielke.PersonManagerApp.UI.ConsoleClient;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public class ServiceCollectionFactory
    {
        public IServiceCollection Create()
        {
            var services = new ServiceCollection();
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonParser, PersonParser>();
            services.AddTransient<IFileReader, FileReader>();
            return services;
        }
    }
}
