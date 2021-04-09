using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBox.App.GUI.Messages;

namespace ToyBox.App.GUI.ViewModel
{
    public class SenderViewModel : ViewModelBase
    {
        public RelayCommand OnClickCommand { get; set; }
        private string _textBoxText;

        public string TextBoxText
        {
            get { return _textBoxText; }
            set
            {
                _textBoxText = value;
                RaisePropertyChanged("TextBoxText");
            }
        }

        public void OnSendBtn_Clicked(object sender, EventArgs e)
        {
            var viewModelMessage = new ViewModelMessage()
            {
                Text = TextBoxText
            };

            Messenger.Default.Send(viewModelMessage);
        }

        public SenderViewModel()
        {
        }
    }
}