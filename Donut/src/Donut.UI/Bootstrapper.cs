using Autofac;
using Donut.Core.Interfaces.Repositories;
using Donut.Infrastructure.Persistence;
using Donut.Infrastructure.Repositories;
using Donut.UI.ViewModels;

namespace Donut.UI
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<AppDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<ItemNavigationViewModel>().As<IItemNavigationViewModel>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            //builder.RegisterType<ItemsViewModel>().As<IItemsViewModel>(); 

            return builder.Build();
        }
    }
}
