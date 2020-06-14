using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using VirusSim.ViewModels;
using VirusSim.Data;
using VirusSim.Models;
using Shared;

namespace VirusSim
{
    public class Ioc
    {
        private static readonly ServiceProvider _provider;

        static Ioc()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<AgeViewModel>();
            services.AddSingleton<ContactFilterViewModel>();
            services.AddSingleton<OverViewViewModel>();
            services.AddSingleton<DefaultViewModel>();

            services.AddSingleton<IDataProvider<Person>>(new DataProvider<Person>(Constants.BIG_DATA_PERSONS_PATH));
            services.AddSingleton<IDataProvider<Contact>>(new DataProvider<Contact>(Constants.BIG_DATA_CONTACTS_PATH));

            services.AddSingleton<IPersonAgeInfoProvider>(new PersonAgeInfoProvider(Constants.BIG_DATA_PERSONS_PATH));
            services.AddSingleton<IFilteredContactsProvider>(new FilteredContactsProvider(Constants.BIG_DATA_CONTACTS_PATH));

            _provider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => _provider.GetRequiredService<T>();
    }
}
