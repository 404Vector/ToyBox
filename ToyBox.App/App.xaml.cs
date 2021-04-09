using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToyBox.App.GUI.ViewModel;

namespace ToyBox.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ViewModelLocator locator;

        public ViewModelLocator Locator => locator;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            locator = Resources["Locator"] as ViewModelLocator;
        }
    }
}