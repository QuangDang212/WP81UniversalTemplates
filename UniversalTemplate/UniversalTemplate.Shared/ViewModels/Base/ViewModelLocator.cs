namespace UniversalTemplate.Base
{
    using Microsoft.Practices.Unity;
    using UniversalTemplate.ViewModels;

    public class ViewModelLocator
    {
        private IUnityContainer container;

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
