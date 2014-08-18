namespace UniversalTemplate.ViewModels
{
    using System.Threading.Tasks;
    using UniversalTemplate.Base;
    using Windows.UI.Xaml.Navigation;

    public class MainViewModel : ViewModelBase
    {
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }

        public override Task OnNavigatingFrom(NavigatingCancelEventArgs args)
        {
            return null;
        }

        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            return null;
        }

        public MainViewModel()
        {

        }
    }
}
