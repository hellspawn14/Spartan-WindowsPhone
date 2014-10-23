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
using Microsoft.Phone.Globalization;
using System.Globalization;
using System.Collections.ObjectModel;
using System.IO;

namespace com.spartan.windowsphone
{
    public partial class EventSearch : PhoneApplicationPage
    {
        

        ObservableCollection<EventResult> results = new ObservableCollection<EventResult>();


        public EventSearch()
        {
            InitializeComponent();
            this.EventResultado.ItemsSource = results;
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String searchParam = "";
            //MessageBox.Show("Entro");
            if (this.Basketball.IsChecked == true)
            {
                searchParam = "Basketball";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.getEventsSearchParamCompleted += client_search_completed;
                client.getEventsSearchParamAsync(searchParam);
            }
            else if (this.Soccer.IsChecked == true)
            {
                searchParam = "Soccer";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.getEventsSearchParamCompleted += client_search_completed;
                client.getEventsSearchParamAsync(searchParam);
            }
            else if (this.Voleyball.IsChecked == true)
            {
                searchParam = "Voleyball";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.getEventsSearchParamCompleted += client_search_completed;
                client.getEventsSearchParamAsync(searchParam);
            }
            else if (this.Tennis.IsChecked == true)
            {
                searchParam = "Tennis";
                RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
                client.getEventsSearchParamCompleted += client_search_completed;
                client.getEventsSearchParamAsync(searchParam);
            }
            else
            {
                MessageBox.Show("Must select a sport");
            }
        }

        private void client_search_completed(object sender, RegularEventService.getEventsSearchParamCompletedEventArgs e)
        {
            String res = e.Result.ToString();
            //MessageBox.Show(res);
            String[] eventos = res.Trim().Split('@');
            String eventoActual = "";
            String[] datosEvento = null;
            int idEvent;
            String sport;
            String description;
            String date;
            int spots;
            String state;
            String place;
            String details;
        
            EventResult R = null;
            for (int i = 1 ; i < eventos.Length; i++)
            {
                eventoActual = eventos[i].Trim();
                datosEvento = eventoActual.Split('%');
                
                idEvent = Convert.ToInt32(datosEvento[0]);
                sport = datosEvento[1];
                description = datosEvento[2];
                date = datosEvento[3];
                spots = Convert.ToInt32(datosEvento[4]);
                state = datosEvento[5];
                place = datosEvento[6];
                details = datosEvento[7];
                R = new EventResult(idEvent, sport, description, date, spots, state, place, details);
                results.Add(R);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Obtiene el id del usuario 
            int userId = 1000;
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
                    userId = Convert.ToInt32(line.Trim());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loading data");
            }

            EventResult req = (sender as Button).DataContext as EventResult;
            int idEvent = req.idEvent;
            MessageBox.Show(idEvent + "Evento");
            MessageBox.Show(userId + "User");
            RegularEventService.EventServiceClient client = new RegularEventService.EventServiceClient();
            client.registerInEventCompleted += client_registerInEventCompleted;
            client.registerInEventAsync(idEvent, userId);

        }

        private void client_registerInEventCompleted(object sender, RegularEventService.registerInEventCompletedEventArgs e)
        {
            String res = e.Result.ToString();
            MessageBox.Show(res);
        }
    }


    public class EventResult
    {
        public int idEvent
        {
            get;
            set;
        }
        
        public String sport
        {
            get;
            set;
        }
        
        public String description
        {
            get;
            set;
        }

        public String date
        {
            get;
            set;
        }

        public int spots
        {
            get;
            set;
        }

        public String state
        {
            get;
            set;
        }

        public String place
        {
            get;
            set;
        }

        public String details
        {
            get;
            set;
        }

        public EventResult(int idEvent, String sport, String description, String date, int spots, String state, String place, String details)
        {
            this.idEvent = idEvent;
            this.sport = sport;
            this.description = description;
            this.date = date;
            this.spots = spots;
            this.state = state;
            this.place = place;
            this.details = details;
        }
    }

    public class AlphaKeyGroup<T> : List<T>
    {
        /// <summary>
        /// The delegate that is used to get the key information.
        /// </summary>
        /// <param name="item">An object of type T</param>
        /// <returns>The key value to use for this object</returns>
        public delegate string GetKeyDelegate(T item);

        /// <summary>
        /// The Key of this group.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="key">The key for this group.</param>
        public AlphaKeyGroup(string key)
        {
            Key = key;
        }

        /// <summary>
        /// Create a list of AlphaGroup<T> with keys set by a SortedLocaleGrouping.
        /// </summary>
        /// <param name="slg">The </param>
        /// <returns>Theitems source for a LongListSelector</returns>
        private static List<AlphaKeyGroup<T>> CreateGroups(SortedLocaleGrouping slg)
        {
            List<AlphaKeyGroup<T>> list = new List<AlphaKeyGroup<T>>();

            foreach (string key in slg.GroupDisplayNames)
            {
                list.Add(new AlphaKeyGroup<T>(key));
            }

            return list;
        }

        /// <summary>
        /// Create a list of AlphaGroup<T> with keys set by a SortedLocaleGrouping.
        /// </summary>
        /// <param name="items">The items to place in the groups.</param>
        /// <param name="ci">The CultureInfo to group and sort by.</param>
        /// <param name="getKey">A delegate to get the key from an item.</param>
        /// <param name="sort">Will sort the data if true.</param>
        /// <returns>An items source for a LongListSelector</returns>
        public static List<AlphaKeyGroup<T>> CreateGroups(IEnumerable<T> items, CultureInfo ci, GetKeyDelegate getKey, bool sort)
        {
            SortedLocaleGrouping slg = new SortedLocaleGrouping(ci);
            List<AlphaKeyGroup<T>> list = CreateGroups(slg);

            foreach (T item in items)
            {
                int index = 0;
                if (slg.SupportsPhonetics)
                {
                    //check if your database has yomi string for item
                    //if it does not, then do you want to generate Yomi or ask the user for this item.
                    //index = slg.GetGroupIndex(getKey(Yomiof(item)));
                }
                else
                {
                    index = slg.GetGroupIndex(getKey(item));
                }
                if (index >= 0 && index < list.Count)
                {
                    list[index].Add(item);
                }
            }

            if (sort)
            {
                foreach (AlphaKeyGroup<T> group in list)
                {
                    group.Sort((c0, c1) => { return ci.CompareInfo.Compare(getKey(c0), getKey(c1)); });
                }
            }

            return list;
        }

    }
}