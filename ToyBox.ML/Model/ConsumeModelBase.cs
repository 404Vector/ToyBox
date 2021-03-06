// This file was auto-generated by ML.NET Model Builder.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ML;

namespace ToyBox.ML.Model
{
    public class ConsumeModelBase<TSrc, TDst> where TSrc : ModelInputBase where TDst : ModelOutputBase, new()
    {
        private static Lazy<PredictionEngine<TSrc, TDst>> PredictionEngine = new Lazy<PredictionEngine<TSrc, TDst>>(CreatePredictionEngine);

        public static string ModelPath { get; set; } = IModelBuilder.GetAbsolutePath(@"Model\MLModel.zip");

        public static PredictionEngine<TSrc, TDst> CreatePredictionEngine()
        {
            // Create new MLContext
            MLContext mlContext = new MLContext();

            // Load model & create prediction engine
            ITransformer mlModel = mlContext.Model.Load(ModelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<TSrc, TDst>(mlModel);

            return predEngine;
        }

        // For more info on consuming ML.NET models, visit https://aka.ms/mlnet-consume
        // Method for consuming model in your app
        public static TDst Predict(TSrc input)
        {
            TDst result = PredictionEngine.Value.Predict(input);
            return result;
        }
    }
}