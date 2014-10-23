using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.IO;

namespace com.spartan.windowsphone
{
    public partial class MainPage : PhoneApplicationPage
    {
        String userId;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            userId = "0";
            loadComp();
            setScore();
        }

        private void loadComp()
        {
            userId = "";
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
                    userId = line.Trim();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Loading data");
            }
            
        }

        public void setScore()
        {
            int id = Convert.ToInt32(userId);
            //MessageBox.Show(id + "pp");
            RegistrationService.UserServiceClient client = new RegistrationService.UserServiceClient();
            client.getScoreCompleted+= client_getScoreCompleted;
            client.getScoreAsync(id);
        }

        void client_getScoreCompleted(object sender, RegistrationService.getScoreCompletedEventArgs e)
        {
            String res = e.Result.ToString();
           //MessageBox.Show(res);
            this.ScrText.Text = res;
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

        //Ir a los eventos creados por el usuario 
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
            System.IO.StreamWriter file = new System.IO.StreamWriter("SessionKey.txt");
            file.WriteLine("0");

            file.Close();
            /*
            const string fileName = "SessionKey.txt";
            IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication();
            file.DeleteFile(fileName);
            using (StreamWriter write = new StreamWriter(new IsolatedStorageFileStream(fileName, FileMode.Create, FileAccess.Write, file)))
            {
                write.WriteLine("0");
                write.Close();
            }*/
            NavigationService.Navigate(new Uri("/SignIn.xaml", UriKind.Relative));
        }


    }
}