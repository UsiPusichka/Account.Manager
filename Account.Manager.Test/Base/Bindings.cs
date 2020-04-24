using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Concrete;
using Account.Manager.Repository.Context;
using Account.Manager.Service.Inner.Abstract;
using Account.Manager.Service.Inner.Concrete;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Account.Manager.Test.Base
{
    public static class Bindings
    {
        /// <summary>
        /// Bind app services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceProvider Bind(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(config =>
                config.UseInMemoryDatabase("DataContext").ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            );

            var builder = new ContainerBuilder();

            builder.RegisterType<SmsRepository>().As<ISmsRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TokenRepository>().As<ITokenRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserProfileRepository>().As<IUserProfileRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserProfileRoleRepository>().As<IUserProfileRoleRepository>().InstancePerLifetimeScope();

            builder.RegisterType<EnvironmentProvider>().As<IEnvironmentProvider>().InstancePerLifetimeScope();
            builder.RegisterType<RequestContext>().As<IRequestContext>().InstancePerLifetimeScope();
            builder.RegisterType<EmailHashRepository>().As<IEmailHashRepository>().InstancePerLifetimeScope();
            builder.RegisterType<Md5PasswordEncrypt>().As<IPasswordEncrypt>().InstancePerLifetimeScope();
            builder.RegisterType<CodeGenerator>().As<ICodeGenerator>().InstancePerLifetimeScope();

            builder.Populate(services);

            var container = builder.Build();
            return new AutofacServiceProvider(container);
        }
    }
}
