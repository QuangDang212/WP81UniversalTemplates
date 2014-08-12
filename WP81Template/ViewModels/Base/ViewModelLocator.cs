namespace WP81Template.ViewModels.Base
{
    using Microsoft.Practices.Unity;
    using WP81Template.ViewModels;

    public class ViewModelLocator
    {
        IUnityContainer container;

        public ViewModelLocator()
        {
            container = new UnityContainer();
            // Services
            //container.RegisterType<IService, Service>(new ContainerControlledLifetimeManager());

            container.RegisterType<MainViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get { return container.Resolve<MainViewModel>(); }
        }
    }
}
