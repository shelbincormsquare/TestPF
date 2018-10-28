using Autofac;
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
            builder.RegisterType<LoginViewModel>().As<ILoginViewModel>();
            
            return builder.Build();
        }
    }
}
