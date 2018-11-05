using Autofac;
using CupCakeWpf.UI.Services;
using CupCakeWpf.UI.Services.Interfaces;
using CupCakeWpf.UI.ViewModels;
using CupCakeWpf.UI.ViewModels.Interfaces;

namespace CupCakeWpf.UI.StartUp
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            //builder.RegisterType<FriendOrganizerDbContext>().AsSelf();


            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<ItemService>().As<IItemService>();
            builder.RegisterType<ItemListViewModel>().As<IItemListViewModel>();
            builder.RegisterType<ItemsViewModel>().As<IItemsViewModel>();
            //builder.RegisterType<ItemRepository>().As<IItemRepository>();
            //builder.RegisterType<ItemListViewModel>().As<IItemListViewModel>();
            //builder.RegisterType<ItemEditorViewModel>().As<IItemEditorViewModel>();
            //builder.RegisterType<ItemsViewModel>().As<IItemsViewModel>();

            return builder.Build();
        }
    }
}
