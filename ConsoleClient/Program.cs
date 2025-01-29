using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonParser, PersonParser>();
            services.AddTransient<IFileReader, FileReader>();

            var provider = services.BuildServiceProvider();

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();
            
            displayCommands.DisplayAllAdults();

            displayCommands.DisplayAllChildren();
        }
    }
}
