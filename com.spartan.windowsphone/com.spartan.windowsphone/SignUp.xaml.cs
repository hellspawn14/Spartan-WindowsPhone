using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace com.spartan.windowsphone
{
    public partial class SignUp : PhoneApplicationPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //Registrar usuario 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Verificar que las contraseñas correspondan
            if(this.P1.Password.Equals(this.P2.Password))
            {
                RegistrationService.UserServiceClient client = new RegistrationService.UserServiceClient();
                client.registerCompleted += client_testCompleted;
                client.registerAsync(this.UserText.Text, this.P1.Password, this.PhoneText.Text);
            }
            //Enviar mensaje
            else
            {
                MessageBox.Show("The password does't match");
            }
        }

        private void client_testCompleted(object sender, RegistrationService.registerCompletedEventArgs e)
        {
            String res = e.Result.ToString();
            MessageBox.Show(res);
        }
    }
}