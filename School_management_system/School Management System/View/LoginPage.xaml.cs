using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace School_Management_System.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void loginclick_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void cancel_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "1")
            {
                MessageDialog dlg = new MessageDialog("Welcome to the world");
                dlg.ShowAsync();
                Frame rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(StudentRegistration));
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Invalid Username or Password\r\n" + " Contact Admin");
                dlg.ShowAsync();
            }
        }
    }
}
