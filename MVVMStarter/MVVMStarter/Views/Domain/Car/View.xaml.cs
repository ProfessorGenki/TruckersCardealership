using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MVVMStarter.ViewModels.Domain.Car;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MVVMStarter.Views.Domain.Car
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View : Page
    {
        public View()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];

            string selected = (string)item.Content;

            if (selected == "Create")
            {
                ((MasterDetailsViewModel)DataContext).SelectCreateCommand.Execute(null);
            }

            if (selected == "Update")
            {
                ((MasterDetailsViewModel)DataContext).SelectUpdateCommand.Execute(null);
            }

            if (selected == "Delete")
            {
                ((MasterDetailsViewModel)DataContext).SelectDeleteCommand.Execute(null);

            }
        }
    }
}
