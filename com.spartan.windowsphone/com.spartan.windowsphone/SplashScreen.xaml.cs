using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Resources;
using System.Reflection;
using Windows.Storage;

using System;
using System.Device.Location;
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Storage;

namespace com.spartan.windowsphone
{
    public partial class SplashScreen : PhoneApplicationPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String ans = "";
            StorageFolder foldera = ApplicationData.Current.LocalFolder;
            try
            {
                var ResrouceStream = App.GetResourceStream(new Uri("Resources/SessionKey.txt", UriKind.Relative));
                Stream myFileStream = ResrouceStream.Stream;
                // Read the data.
                using (StreamReader streamReader = new StreamReader(myFileStream))
                {
                    String line = streamReader.ReadLine();
                    streamReader.Close();
                    myFileStream.Close();
                    ans = line.Trim();
                }
                
                if (ans.Equals("0"))
                {
                    NavigationService.Navigate(new Uri("/SignIn.xaml", UriKind.Relative));
                }

                else
                {
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ola ke ase");
            }
        }
    }
}