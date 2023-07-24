using System.Collections.ObjectModel;

namespace UnoApp1
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<int> RandomList = new();

        public MainPage()
        {
            this.InitializeComponent();

            var random = new Random();

            while (RandomList.Count < 60)
            {
                RandomList.Add(random.Next(200, 1000));
            }

            gv.ItemsSource = RandomList;
        }

        private void SwipeItem_Invoked(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {

        }
    }
}