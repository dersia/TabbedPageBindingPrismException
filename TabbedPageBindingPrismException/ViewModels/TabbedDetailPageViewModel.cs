using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TabbedPageBindingPrismException.Models;
using Xamarin.Essentials;

namespace TabbedPageBindingPrismException.ViewModels
{
    public class TabbedDetailPageViewModel : BaseViewModel
    {
        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items 
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public string State => "tabbedDetailPage";

        public TabbedDetailPageViewModel()
        {
            Items = new ObservableCollection<Item>();
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            await LoadData();
            base.OnNavigatedTo(parameters);
        }

        public async Task LoadData()
        {
            var data = new ObservableCollection<Item>
            {
                new Item { Title = "TabA", Text1 = "TabA1", Text2 = "TabA2", Text3 = "TabA3", Text4 = "TabA4"},
                new Item { Title = "TabB", Text1 = "TabB1", Text2 = "TabB2", Text3 = "TabB3", Text4 = "TabB4"}
            };
            var path = Path.Combine(FileSystem.CacheDirectory, "abc.txt");
            if (File.Exists(path))
            {
                await File.ReadAllTextAsync(path);
            }
            else
            {
                await File.WriteAllTextAsync(path, System.Text.Json.JsonSerializer.Serialize(data));
            }
            Items = data;
        }
    }
}
