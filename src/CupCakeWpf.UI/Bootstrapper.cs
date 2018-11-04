using Autofac;
using CupCakeWpf.UI.ViewModels;

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
            //builder.RegisterType<LoginViewModel>().As<ILoginViewModel>();
            //builder.RegisterType<InvoiceEditorViewModel>().As<IInvoiceEditorViewModel>();
            //builder.RegisterType<ItemRepository>().As<IItemRepository>();
            //builder.RegisterType<ItemListViewModel>().As<IItemListViewModel>();
            //builder.RegisterType<ItemEditorViewModel>().As<IItemEditorViewModel>();
            //builder.RegisterType<ItemsViewModel>().As<IItemsViewModel>();

            return builder.Build();
        }
    }
}
