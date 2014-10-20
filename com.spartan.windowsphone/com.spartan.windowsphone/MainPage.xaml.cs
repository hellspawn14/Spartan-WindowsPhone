using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace com.spartan.windowsphone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        //Ir a buscar eventos normales
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EventSearch.xaml", UriKind.Relative));
        }

        //Ir a crear eventos
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EventCreatexaml.xaml", UriKind.Relative));
        }

        //Ir a buscar eventos publicos
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/searchPublicEvent.xaml", UriKind.Relative));
        }

        //
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MyEvents.xaml", UriKind.Relative));
        }

        //Ir a crear equipo
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CreateTeam.xaml", UriKind.Relative));
        }

        //Ir a Join team 
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/JoinTeam.xaml", UriKind.Relative));
        }

        //Ir a my teams
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MyTeams.xaml", UriKind.Relative));
        }

        //Ir a new Tournament
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/newTournament.xaml", UriKind.Relative));
        }

        //Ir a join tournament
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/JoinTournament.xaml", UriKind.Relative));
        }

        //Ir a my tournament
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MyTournaments.xaml", UriKind.Relative));
        }

        //Ir a asistencias
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ReviewAssistences.xaml", UriKind.Relative));
        }

        //Ir a cambiar pass
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/changePass.xaml", UriKind.Relative));
        }

        //Ir a cerrar sesion 
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SignIn.xaml", UriKind.Relative));
        }
        
    }
}