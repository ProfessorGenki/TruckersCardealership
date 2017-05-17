﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MVVMStarter.Common;
using MVVMStarter.Configuration.App;
#pragma warning disable CS4014

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MVVMStarter.Views.App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AppConfig.Setup();
            AppFrame.Navigate(typeof(OpeningView));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            AppSplitView.IsPaneOpen = !AppSplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (ImageView.IsSelected)
            {
                AppFrame.Navigate(typeof(App.ImageView));
            }
            if (CustomerView.IsSelected)
            {
                AppFrame.Navigate(typeof(Domain.Customer.View));
            }
            if (CarView.IsSelected)
            {
                AppFrame.Navigate(typeof(Domain.Car.View));
            }
            if (SalespersonView.IsSelected)
            {
                AppFrame.Navigate(typeof(Domain.Salesperson.View));
            }
            if (SalesView.IsSelected)
            {
                AppFrame.Navigate(typeof(Domain.Sale.View));
            }
            string nameOfSelection = ((ListBoxItem)e.AddedItems[0]).Name;
            if (nameOfSelection == "Load")
            {
                AppFrame.Navigate(typeof(OpeningView));
                UserActionPresenter.PresentMessageOkCancel("Are you sure you want to LOAD model data?", "Load", new RelayCommand(AppConfig.Load));
            }
            if (nameOfSelection == "Save")
            {
                AppFrame.Navigate(typeof(OpeningView));
                UserActionPresenter.PresentMessageOkCancel("Are you sure you want to SAVE model data?", "Save", new RelayCommand(AppConfig.Save));
            }
            if (nameOfSelection == "Quit")
            {
                AppFrame.Navigate(typeof(OpeningView));
                UserActionPresenter.PresentMessageOkCancel("Are you sure you want to QUIT?", "QUIT", new RelayCommand(Application.Current.Exit));
            }
        }
    }
}
