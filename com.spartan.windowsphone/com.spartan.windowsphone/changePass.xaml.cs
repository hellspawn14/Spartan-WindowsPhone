using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.IO;

namespace com.spartan.windowsphone
{
    public partial class changePass : PhoneApplicationPage
    {
        public changePass()
        {
            InitializeComponent();
        }

        //Cambio de contraseña 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String old = this.oldPass.Password;
            String nw = this.nwPass.Password;


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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loading data");
            }

            
            //MessageBox.Show(userId + " ola ke ase");

            AutentificationService.AuthentificationServiceClient client = new AutentificationService.AuthentificationServiceClient();
            client.changePassCompleted += client_changedCompleted;
            client.changePassAsync(userId, old, nw);
            
        }

        private void client_changedCompleted(object sender, AutentificationService.changePassCompletedEventArgs e)
        {
            String res = e.Result.ToString();
            MessageBox.Show(res);
        }
    }
}