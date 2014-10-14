namespace WP81Template.ViewModels.Base
{
    using Autofac;
    using WP81Template.ViewModels;

    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            // Add Services here
            //builder.RegisterType<Service>().As<IService>().IsSingleInstance();

            builder.RegisterType<MainViewModel>();

            this.container = builder.Build();
 
        }

        public MainViewModel MainViewModel
        {
            get { return container.Resolve<MainViewModel>(); }
        }
    }
}
