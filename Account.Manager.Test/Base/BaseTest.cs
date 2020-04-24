using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Account.Manager.Test.Base
{
    public class BaseTest
    {
        protected IServiceProvider ServiceProvider;
        protected IConfiguration Configuration;

        public BaseTest()
        {
            Configuration = InitConfiguration();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton(Configuration);
            ServiceProvider = ConfigureServices(serviceCollection);

            //FillTable().Wait();
        }
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            return config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var provider = Bindings.Bind(services, Configuration);
            return provider;
        }
    }
}
