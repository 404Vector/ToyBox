// This file was auto-generated by ML.NET Model Builder.

using Microsoft.ML.Data;
using ToyBox.ML.Model;
using ToyBox.StdLib.Mvvm;

namespace ToyBox.ML.TaxiFarePrediction.Model
{
    public class ModelInput : ModelInputBase
    {
        private string vendor_id;
        private float rate_code;
        private float passenger_count;
        private float trip_time_in_secs;
        private float trip_distance;
        private string payment_type;
        private float fare_amount;

        [ColumnName("vendor_id"), LoadColumn(0)]
        public string Vendor_id { get => vendor_id; set => OnPropertyChanged(ref vendor_id, value); }

        [ColumnName("rate_code"), LoadColumn(1)]
        public float Rate_code { get => rate_code; set => OnPropertyChanged(ref rate_code, value); }

        [ColumnName("passenger_count"), LoadColumn(2)]
        public float Passenger_count { get => passenger_count; set => OnPropertyChanged(ref passenger_count, value); }

        [ColumnName("trip_time_in_secs"), LoadColumn(3)]
        public float Trip_time_in_secs { get => trip_time_in_secs; set => OnPropertyChanged(ref trip_time_in_secs, value); }

        [ColumnName("trip_distance"), LoadColumn(4)]
        public float Trip_distance { get => trip_distance; set => OnPropertyChanged(ref trip_distance, value); }

        [ColumnName("payment_type"), LoadColumn(5)]
        public string Payment_type { get => payment_type; set => OnPropertyChanged(ref payment_type, value); }

        [ColumnName("fare_amount"), LoadColumn(6)]
        public float Fare_amount { get => fare_amount; set => OnPropertyChanged(ref fare_amount, value); }
    }
}