using Prism.Mvvm;
using Prism.Navigation;

namespace TabbedPageBindingPrismException.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }
        public virtual void OnNavigatedTo(INavigationParameters parameters) { }
    }
}
