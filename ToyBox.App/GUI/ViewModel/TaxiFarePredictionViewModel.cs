using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBox.ML.TaxiFarePrediction.Model;

namespace ToyBox.App.GUI.ViewModel
{
    public class TaxiFarePredictionViewModel : ViewModelBase
    {
        private ModelInput modelInputProperty = new ModelInput()
        {
            Vendor_id = @"CMT",
            Rate_code = 1F,
            Passenger_count = 1F,
            Trip_distance = 3.8F,
            Payment_type = @"CRD",
        };

        private ModelOutput modelOutputProperty = new ModelOutput();

        public ModelInput ModelInputProperty { get => modelInputProperty; set => modelInputProperty = value; }

        public ModelOutput ModelOutputProperty { get => modelOutputProperty; set => modelOutputProperty = value; }

        public void OnPredictBtn_Clicked(object sender, EventArgs e)
        {
            ModelOutputProperty.Score = ConsumeModel.Predict(ModelInputProperty).Score;
        }

        public TaxiFarePredictionViewModel()
        {
        }
    }
}