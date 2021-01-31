using System;
using ProCodeGuide_MLNET_SampleML.Model;

namespace ProCodeGuide.MLNET.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput()
            {
                Col0 = "This restaurant was wonderful."
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
            string sentiment = result.Prediction == "1" ? "Positive" : "Negative";
            Console.WriteLine($"Text: {input.Col0}\nSentiment: {sentiment}");
        }
    }
}
