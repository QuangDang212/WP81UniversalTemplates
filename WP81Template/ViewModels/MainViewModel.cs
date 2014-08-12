namespace WP81Template.ViewModels
{
    using System.Threading.Tasks;
    using WP81Template.ViewModels.Base;

    public class MainViewModel : ViewModelBase
    {
        public override Task OnNavigatedFrom(Windows.UI.Xaml.Navigation.NavigationEventArgs args)
        {
            return null;
        }

        public override Task OnNavigatingFrom(Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs args)
        {
            return null;
        }

        public override Task OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs args)
        {
            return null;
        }

        public MainViewModel()
        {

        }
    }
}
