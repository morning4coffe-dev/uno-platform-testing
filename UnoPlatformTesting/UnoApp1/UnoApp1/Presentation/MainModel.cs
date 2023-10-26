using System.Collections.ObjectModel;

namespace UnoApp1.Presentation
{
    public partial record MainModel
    {
        private INavigator _navigator;

        public MainModel(
            IStringLocalizer localizer,
            IOptions<AppConfig> appInfo,
            INavigator navigator)
        {
            _navigator = navigator;
            Title = "Main";
            Title += $" - {localizer["ApplicationName"]}";
            Title += $" - {appInfo?.Value?.Environment}";
        }

        public string? Title { get; }

        public IState<string> Name => State<string>.Value(this, () => string.Empty);

        public async Task GoToSecond()
        {
            var name = await Name;
            await _navigator.NavigateViewModelAsync<SecondModel>(this, data: new Entity(name!));
        }

        public class SampleItem
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }

        public ObservableCollection<SampleItem> SampleItems = new()
        {
            new SampleItem { Name = "Item 1", Value = 10 },
            new SampleItem { Name = "Item 2", Value = 20 },
            new SampleItem { Name = "Item 3", Value = 20 },
            new SampleItem { Name = "Item 4", Value = 40 },
            new SampleItem { Name = "Item 5", Value = 50 },
            new SampleItem { Name = "Item 6", Value = 20 },
            new SampleItem { Name = "Item 7", Value = 10 },
            new SampleItem { Name = "Item 8", Value = 50 },
            new SampleItem { Name = "Item 1", Value = 10 },
            new SampleItem { Name = "Item 2", Value = 20 },
            new SampleItem { Name = "Item 3", Value = 20 },
            new SampleItem { Name = "Item 4", Value = 40 },
            new SampleItem { Name = "Item 5", Value = 50 },
            new SampleItem { Name = "Item 6", Value = 20 },
            new SampleItem { Name = "Item 7", Value = 10 },
            new SampleItem { Name = "Item 8", Value = 50 },
            new SampleItem { Name = "Item 1", Value = 10 },
            new SampleItem { Name = "Item 2", Value = 20 },
            new SampleItem { Name = "Item 3", Value = 20 },
            new SampleItem { Name = "Item 4", Value = 40 },
            new SampleItem { Name = "Item 5", Value = 50 },
            new SampleItem { Name = "Item 6", Value = 20 },
            new SampleItem { Name = "Item 7", Value = 10 },
            new SampleItem { Name = "Item 8", Value = 50 },
            new SampleItem { Name = "Item 1", Value = 10 },
            new SampleItem { Name = "Item 2", Value = 20 },
            new SampleItem { Name = "Item 3", Value = 20 },
            new SampleItem { Name = "Item 4", Value = 40 },
            new SampleItem { Name = "Item 5", Value = 50 },
            new SampleItem { Name = "Item 6", Value = 20 },
            new SampleItem { Name = "Item 7", Value = 10 },
            new SampleItem { Name = "Item 8", Value = 50 },
        };

    }
}