using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;
using Windows.Devices.Geolocation;
using Windows.Storage;
using System.IO;
using System.IO.IsolatedStorage;


namespace com.spartan.windowsphone
{
    public partial class EventCreatexaml : PhoneApplicationPage
    {
        Geolocator geo;

        double lat;
        double lon;

        public EventCreatexaml()
        {
            InitializeComponent(); 
            Map MyMap = new Map();
            MyMap.CartographicMode = MapCartographicMode.Terrain;
            geo = null;
            lat = 0.0;
            lon = 0.0;
            MyMap.Center = new GeoCoordinate(lat, lon);
            initLocation();
            ContentPanelMap.Children.Add(MyMap);
        }

        private async void initLocation()
        {
            geo = new Geolocator();
            geo.DesiredAccuracyInMeters = 50;

            Geoposition pos = await geo.GetGeopositionAsync();
            lat = pos.Coordinate.Latitude;
            lon = pos.Coordinate.Longitude;
            //Pinta la posicion actual en el mapa
            MyMap.Center = new GeoCoordinate(lat, lon);
            MyMap.ZoomLevel = 16;
            MyMap.LandmarksEnabled = true;
            MyMap.PedestrianFeaturesEnabled = true;
        }

        //Create event
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //public String createEvent(String sport, String description, String date, int eventAuthor, int availableSpots, String state, String place, String key, String details)
            String sport = "No deporte";
            String description = this.Description.Text;
            DateTime thisDay = DateTime.Today;
            String date = thisDay.ToString("g");
            int eventAuthor = Convert.ToInt32(this.getIdUser().Trim());
            int availableSpots = 1000;
            try
            {
                availableSpots = Convert.ToInt32(this.Spots.Text.Trim());
            }
            catch(Exception)
            {
                MessageBox.Show("Must specify a number of available spots");
            }
            if(availableSpots == 0)
            {
                MessageBox.Show("Available spots must be bigger than 0");
            }
            String state = "Open";
            String place = lat + " : " + lon;
            String key = this.Key.Text.Trim();
            String details = this.Details.Text.Trim();

            if (this.Basketball.IsChecked == true && availableSpots > 0)
            {
                sport = "Basketball";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.createEventCompleted += client_createEventCompleted;
                client.createEventAsync(sport, description, date, eventAuthor, availableSpots, state, place, key, details);
            }
            else if (this.Soccer.IsChecked == true && availableSpots > 0)
            {
                sport = "Soccer";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.createEventCompleted += client_createEventCompleted;
                client.createEventAsync(sport, description, date, eventAuthor, availableSpots, state, place, key, details);
            }
            else if (this.Voleyball.IsChecked == true && availableSpots > 0)
            {
                sport = "Voleyball";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.createEventCompleted += client_createEventCompleted;
                client.createEventAsync(sport, description, date, eventAuthor, availableSpots, state, place, key, details);
            }
            else if (this.Tennis.IsChecked == true && availableSpots > 0)
            {
                sport = "Tennis";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.createEventCompleted += client_createEventCompleted;
                client.createEventAsync(sport, description, date, eventAuthor, availableSpots, state, place, key, details);
            }
            else
            {
                MessageBox.Show("Must select a sport");
            }
        }

        private void client_createEventCompleted(object sender, RegularEventService.createEventCompletedEventArgs e)
        {
            String res = e.Result.ToString();
            MessageBox.Show(res);
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private String getIdUser()
        {
            StorageFolder foldera = ApplicationData.Current.LocalFolder;
            String ans = "";
            try
            {
                var ResrouceStream = App.GetResourceStream(new Uri("SessionKey.txt", UriKind.Relative));
                Stream myFileStream = ResrouceStream.Stream;
                // Read the data.
                using (StreamReader streamReader = new StreamReader(myFileStream))
                {
                    String line = streamReader.ReadLine();
                    streamReader.Close();
                    myFileStream.Close();
                    ans = line.Trim();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ola ke ase");
            }
            return ans;
        }
    }
}