using System.Collections.ObjectModel;

namespace UnoApp1;

public sealed partial class MainPage : Page
{
    public ObservableCollection<MyData> Items { get; set; } = new();
    public MyData SelectedItem { get; set; }

    public MainPage()
    {
        this.InitializeComponent();

        Items.Add(new MyData { Name = "Item 1", Description = "Description 1" });
        Items.Add(new MyData { Name = "Item 2", Description = "Description 2" });
        Items.Add(new MyData { Name = "Item 3", Description = "Description 3" });
        Items.Add(new MyData { Name = "Item 4", Description = "Description 4" });
    }

    public class MyData
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}