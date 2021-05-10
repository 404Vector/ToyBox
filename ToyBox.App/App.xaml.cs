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
            var k = new ToyBoxIP.CVFunction();
            var d = k.Add(1, 2);

            var cvc = new ToyBoxIP.CVCore();
            var image = cvc.Commend(1, "C:\\Users\\HYC korea\\Pictures\\Lenna.png");
            var fftImage = cvc.Commend(2, String.Empty, image);
            cvc.Commend(0, "FFT Image", fftImage);
            /*
            var w = new CVFunction();
            var x = w.Add(3, 111);
             */
        }
    }
}