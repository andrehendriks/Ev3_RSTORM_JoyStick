using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Phone_Ev3_RSTORM_JoyStick.Resources;
using Lego.Ev3.Core;
using Lego.Ev3.Phone;
namespace Phone_Ev3_RSTORM_JoyStick
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Brick brick = new Brick(new BluetoothCommunication());
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private async void button_connect_Click(object sender, RoutedEventArgs e)
        {
            await brick.ConnectAsync();
        }

        private void button_disconnect_Click(object sender, RoutedEventArgs e)
        {
            brick.Disconnect();
        }

        private void button_go_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand0();
        }

        private async void BatchCommand0()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 50, 3000, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 50, 3000, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private void button_left_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand1();
        }

        private async void BatchCommand1()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, -50, 900, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, 50, 900, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private void button_right_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand2();
        }

        private async void BatchCommand2()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, 50, 900, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, -50, 900, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            BatchCommand3();
        }

        private async void BatchCommand3()
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.B, -50, 3000, false);
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.C, -50, 3000, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}