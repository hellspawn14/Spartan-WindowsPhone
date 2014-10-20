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

namespace com.spartan.windowsphone
{
    public partial class EventCreatexaml : PhoneApplicationPage
    {
        public EventCreatexaml()
        {
            InitializeComponent(); Map MyMap = new Map();
            MyMap.Center = new GeoCoordinate(47.6097, -122.3331);
            MyMap.ZoomLevel = 16;
            MyMap.LandmarksEnabled = true;
            MyMap.PedestrianFeaturesEnabled = true;
            ContentPanelMap.Children.Add(MyMap);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}