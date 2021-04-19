using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using static Microsoft.ML.DataOperationsCatalog;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms.Text;

namespace ToyBox.ML.SentimentAnalysis
{
    public static class Example
    {
        private static readonly string dataPath = IModelBuilder.GetAbsolutePath(@"Dataset\yelp_labelled.txt");

        public static string DataPath => dataPath;

        private static TrainTestData LoadData(MLContext mlContext)
        {
            IDataView dataView;
            TrainTestData splitDataView;
            //Load dataView from raw data.
            dataView = mlContext.Data.LoadFromTextFile<Model.ModelInput>(dataPath, hasHeader: true);
            //Splitting the dataset for model training and testing.
            splitDataView = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2); // testFraction : Test dataset ratio.
            return splitDataView;
        }

        public static void Run()
        {
            MLContext mLContext;
            TrainTestData splitDataView;
            ITransformer model;

            mLContext = new MLContext();
            splitDataView = LoadData(mLContext);
            model = BuildAndTrainModel(mLContext, splitDataView.TrainSet);
            Evaluate(mLContext, model, splitDataView.TestSet);
            UseModelWithSingleItem(mLContext, model);
            UseModelWithBatchItems(mLContext, model);
        }

        private static ITransformer BuildAndTrainModel(MLContext mLContext, IDataView splitTrainSet)
        {
            var path = IModelBuilder.GetAbsolutePath(@"Model\Model.zip");
            var estimator = mLContext.Transforms.Text.FeaturizeText(outputColumnName: "Features", inputColumnName: nameof(Model.ModelInput.SentimentText));
            var trainer = mLContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: "Label", featureColumnName: "Features");
            var trainingPipelne = estimator.Append(trainer);
            Console.WriteLine("=============== Create and Train the Model ===============");
            var model = trainingPipelne.Fit(splitTrainSet);
            Console.WriteLine("=============== End of training ===============");
            Console.WriteLine("=============== Save Model ===============");
            mLContext.Model.Save(model, splitTrainSet.Schema, path);
            Console.WriteLine("=============== End of saving ===============");
            Console.WriteLine();
            return model;
        }

        private static void Evaluate(MLContext mLContext, ITransformer model, IDataView splitTestSet)
        {
            Console.WriteLine("=============== Evaluating Model accuracy with Test data===============");
            IDataView predictions = model.Transform(splitTestSet);
            var metrics = mLContext.BinaryClassification.Evaluate(data: predictions, labelColumnName: "Label", scoreColumnName: "Score");
            Console.WriteLine();
            Console.WriteLine("Model quality metrics evaluation");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Accuracy: {metrics.Accuracy:P2}");
            Console.WriteLine($"Auc: {metrics.AreaUnderRocCurve:P2}");
            Console.WriteLine($"F1Score: {metrics.F1Score:P2}");
            Console.WriteLine("=============== End of model evaluation ===============");
        }

        private static void UseModelWithSingleItem(MLContext mlContext, ITransformer model)
        {
            PredictionEngine<Model.ModelInput, Model.ModelOutput> predictionFunction = mlContext.Model.CreatePredictionEngine<Model.ModelInput, Model.ModelOutput>(model);
            Model.ModelInput sampleStatement = new Model.ModelInput
            {
                SentimentText = "This was a very bad steak"
            };
            var resultPrediction = predictionFunction.Predict(sampleStatement);
            Console.WriteLine();
            Console.WriteLine("=============== Prediction Test of model with a single sample and test dataset ===============");

            Console.WriteLine();
            Console.WriteLine($"Sentiment: {sampleStatement.Sentiment} | Prediction: {(Convert.ToBoolean(resultPrediction.Prediction) ? "Positive" : "Negative")} | Probability: {resultPrediction.Probability} ");

            Console.WriteLine("=============== End of Predictions ===============");
            Console.WriteLine();
        }

        private static void UseModelWithBatchItems(MLContext mlContext, ITransformer model)
        {
            List<Model.ModelInput> sentiments = new List<Model.ModelInput>()
            {
                new Model.ModelInput
                {
                    SentimentText = "This was a horrible meal"
                },
                new Model.ModelInput
                {
                    SentimentText = "I love this spaghetti."
                }
            };
            IDataView batchComments = mlContext.Data.LoadFromEnumerable(sentiments);

            IDataView predictions = model.Transform(batchComments);

            // Use model to predict whether comment data is Positive (1) or Negative (0).
            List<Model.ModelOutput> predictedResults = mlContext.Data.CreateEnumerable<Model.ModelOutput>(predictions, reuseRowObject: false).ToList();
            Console.WriteLine();

            Console.WriteLine("=============== Prediction Test of loaded model with multiple samples ===============");
            for (int i = 0; i < sentiments.Count; i++)
            {
                Console.WriteLine($"Sentiment: {sentiments[i].SentimentText} | Prediction: {(Convert.ToBoolean(predictedResults[i].Prediction) ? "Positive" : "Negative")} | Probability: {predictedResults[i].Probability} ");
            }
            Console.WriteLine("=============== End of predictions ===============");
        }
    }
}