using Microsoft.ML;
using Recomendador;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadModel(MovieRating testInput)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            DataViewSchema modelSchema;

            // Load trained model
            ITransformer trainedModel = mlContext.Model.Load(@"E:\Development\IA\Recomendador\Model\MovieRecommenderModel.zip", out modelSchema);

            var predictionEngine = mlContext.Model.CreatePredictionEngine<MovieRating, MovieRatingPrediction>(trainedModel);

            
            
            var movieRatingPrediction = predictionEngine.Predict(testInput);

            if (Math.Round(movieRatingPrediction.Score, 1) > 3.5)
            {
                MessageBox.Show("Movie " + testInput.movieId + " is recommended for user " + testInput.userId);
            }
            else
            {
                MessageBox.Show("Movie " + testInput.movieId + " is not recommended for user " + testInput.userId);
            }

//            MessageBox.Show("Peli" + movieRatingPrediction.Label + " Score :" + movieRatingPrediction.Score.ToString()); 

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var testInput = new MovieRating { userId = int.Parse(this.textBoxUserId.Text), movieId = float.Parse(this.textBoxMovieId.Text) };

            this.LoadModel(testInput);
        }
    }
}
