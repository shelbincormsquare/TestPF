using Autofac;
using Donut.Core.Interfaces.Repositories;
using Donut.Infrastructure.Repositories;
using Donut.UI.ViewModels;

namespace Donut.UI
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder(); 
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<ItemRepository>().As<IItemRepository>();
            //builder.RegisterType<ItemListViewModel>().As<IItemListViewModel>();
            //builder.RegisterType<ItemsViewModel>().As<IItemsViewModel>(); 

            return builder.Build();
        }
    }
}
