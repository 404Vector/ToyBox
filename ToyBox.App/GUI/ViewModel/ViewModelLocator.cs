using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MVVMLightSample1" x:Key="Locator" />
  </Application.Resources>

  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

namespace ToyBox.App.GUI.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        public object MainViewModel => SimpleIoc.Default.GetService(typeof(MainViewModel));
        public object SenderViewModel => SimpleIoc.Default.GetService(typeof(SenderViewModel));
        public object ReceiverViewModel => SimpleIoc.Default.GetService(typeof(ReceiverViewModel));
        public object TaxiFarePredictionViewModel => SimpleIoc.Default.GetService(typeof(TaxiFarePredictionViewModel));

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<SenderViewModel>();
            SimpleIoc.Default.Register<ReceiverViewModel>();
            SimpleIoc.Default.Register<TaxiFarePredictionViewModel>();
        }
    }
}