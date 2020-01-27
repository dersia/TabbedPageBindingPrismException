using System;
using Xamarin.Forms;
using TabbedPageBindingPrismException.Views;
using Prism.DryIoc;
using Prism.Ioc;
using TabbedPageBindingPrismException.ViewModels;

namespace TabbedPageBindingPrismException
{
    public partial class App : PrismApplication
    {

        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<DetailedNavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterMenuPage, MasterMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<TabbedDetailPage, TabbedDetailPageViewModel>();
        }
        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync($"/{nameof(MainPage)}/{nameof(DetailedNavigationPage)}/{nameof(TabbedDetailPage)}");
        }
    }
}
