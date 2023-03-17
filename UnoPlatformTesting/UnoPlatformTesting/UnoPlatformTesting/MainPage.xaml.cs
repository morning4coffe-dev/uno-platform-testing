using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace UnoPlatformTesting
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }

    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            ButtonContent = "Hello";
        }


        public string ButtonContent
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Dictionary<string, object> _propertyValueStore = new Dictionary<string, object>();

        protected T GetProperty<T>([CallerMemberName] string propertyName = null)
        {
            return _propertyValueStore.TryGetValue(propertyName, out var value) ? (T)value : default;
        }

        protected void SetProperty<T>(T value, [CallerMemberName] string propertyName = null)
        {
            if (!(_propertyValueStore.TryGetValue(propertyName, out var oldValue) && oldValue?.Equals(value) == true))
            {
                _propertyValueStore[propertyName] = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
