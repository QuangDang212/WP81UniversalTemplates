namespace UniversalTemplate.Base
{
    using Autofac;
    using UniversalTemplate.ViewModels;

    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            // Add Services here
            //builder.RegisterType<Service>().As<IService>().SingleInstance();

            builder.RegisterType<MainViewModel>();

            this.container = builder.Build();
        }

        public MainViewModel MainViewModel
        {
            get { return container.Resolve<MainViewModel>(); }
        }
    }
}
