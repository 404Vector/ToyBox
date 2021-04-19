using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBox.ML.Model;

namespace ToyBox.ML.SentimentAnalysis.Model
{
    public class ModelInput : ModelInputBase
    {
        [LoadColumn(0)]
        public string SentimentText;

        [LoadColumn(1), ColumnName("Label")]
        public bool Sentiment;
    }
}