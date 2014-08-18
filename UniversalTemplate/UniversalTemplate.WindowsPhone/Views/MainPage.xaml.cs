namespace UniversalTemplate
{
    using UniversalTemplate.Views.Base;
    using Windows.UI.Xaml.Navigation;

    public sealed partial class MainPage : PageBase
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
    }
}
