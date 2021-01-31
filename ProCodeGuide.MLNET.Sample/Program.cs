using System;
using ProCodeGuide_MLNET_SampleML.Model;

namespace ProCodeGuide.MLNET.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

        }
    }
}
