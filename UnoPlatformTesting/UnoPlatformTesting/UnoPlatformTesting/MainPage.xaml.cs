using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using static System.Net.Mime.MediaTypeNames;

namespace UnoPlatformTesting
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public async void LaunchUri()
        {
            if (!Uri.TryCreate(textBox.Text, UriKind.Absolute, out var uri))
            {

                return;
            }

            var supportStatus = await Launcher.QueryUriSupportAsync(uri, LaunchQuerySupportType.Uri);
            //On WASM does not continue 

            if (supportStatus == LaunchQuerySupportStatus.Available)
            {
                Launcher.LaunchUriAsync(uri);
            }
            else
            {
                //do something when not available
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LaunchUri();
        }
    }
}
