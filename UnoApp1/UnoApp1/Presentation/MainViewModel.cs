using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace UnoApp1.Presentation
{
    public partial class MainViewModel : ObservableObject
    {
        public string? Title { get; }

        [ObservableProperty]
        private string? name;

        public ICommand GoToSecond { get; }

        [ObservableProperty]
        public Item[] items;

        public MainViewModel(
            INavigator navigator,
            IOptions<AppConfig> appInfo)
        {
            _navigator = navigator;
            Title = $"Main - {appInfo?.Value?.Title}";
            GoToSecond = new AsyncRelayCommand(GoToSecondView);

            items = new Item[] { new Item() { Name = "One" }, new Item() { Name = "Two" }, new Item() { Name = "Three" } };
        }

        private async Task GoToSecondView()
        {
            await _navigator.NavigateViewModelAsync<SecondViewModel>(this, data: new Entity(Name!));
        }

        private INavigator _navigator;

        public class Item
        {
            public string? Name { get; set; }
        }
    }
}