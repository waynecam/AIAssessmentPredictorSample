using System;

namespace AIAssessmentPredictorSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an Assessment comment e.g 'Well Done' \nor Press ESC to stop");
            do
            {
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
                {

                    var userInput = Console.ReadLine();
                    // Add input data
                    var sampleData = new AssessmentPredictionModel.ModelInput()
                    {
                        Col0 = userInput
                    };

                    // Load model and predict output of sample data
                    var result = AssessmentPredictionModel.Predict(sampleData);


                    string grade = result.Prediction;
                    Console.WriteLine($"Text: {sampleData.Col0}\nGrade: {grade}");
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
