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
using System.IO.IsolatedStorage;
using Windows.Storage;

namespace com.spartan.windowsphone
{
    public partial class SignIn : PhoneApplicationPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        //Llamar a servicio web para hacer log in
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.UserText.Text.Equals("User name") || this.UserText.Text.Equals("") || this.UserText.Text.Equals(""))
            {
                MessageBox.Show("Use a valid user name or password");
            }
            else
            {
                AutentificationService.AuthentificationServiceClient client = new AutentificationService.AuthentificationServiceClient();
                client.logInCompleted += client_testCompleted;
                client.logInAsync(this.UserText.Text, this.PassText.Password);
            }
            
        }

        private void client_testCompleted(object sender, AutentificationService.logInCompletedEventArgs e)
        {
            String res = e.Result.ToString();
            if(res.Equals("0"))
            {
                MessageBox.Show("Invalid user or password");
            }
            else
            {
                const string fileName = "SessionKey.txt";
                
                using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    /*
                    if (myIsolatedStorage.FileExists(fileName))
                    {
                        myIsolatedStorage.DeleteFile(fileName);
                    }
                    var stream = myIsolatedStorage.CreateFile(fileName);
                    using (StreamWriter isoStream = new StreamWriter(stream))
                    {
                        MessageBox.Show(res + " serv");
                        isoStream.WriteLine(res);
                    }*/

                    string lines = res;

                    // Write the string to a file.
                    System.IO.StreamWriter file = new System.IO.StreamWriter("SessionKey.txt");
                    file.WriteLine(lines);

                    file.Close();

                    String userId = "";
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
                            //MessageBox.Show(userId + " pag");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loading data");
                    }

                }

                //Ir a la pagina
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SignUp.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NoRegistration.xaml", UriKind.Relative));
        }
    }
}