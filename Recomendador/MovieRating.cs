using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recomendador
{
    /// <summary>
    /// MovieRating specifies an input data class. The LoadColumn(Maps member to specific field in text file.) attribute specifies which columns (by column index) in the dataset should be loaded. The userId and movieId columns are your Features (the inputs you will give the model to predict the Label), and the rating column is the Label that you will predict (the output of the model)
    /// </summary>

    ///MovieRating specifies an input data class.
    public class MovieRating
    {
        //The other three columns, userId, movieId, and timestamp are all Features 
        [LoadColumn(0)]
        public float userId;
        [LoadColumn(1)]
        public float movieId;
        /// <summary>
        /// and the column with the returned prediction is called the Label
        /// </summary>
        [LoadColumn(2)]
        public float Label;

        /*In machine learning, the columns that are used to make a prediction are called Features, and the column with the returned prediction is called the Label. You want to predict movie ratings, so the rating column is the Label.The other three columns, userId, movieId, and timestamp are all Features used to predict the Label. t's up to you to decide which Features are used to predict the Label. You can also use methods like permutation feature importance to help with selecting the best Features. In this case, you should eliminate the timestamp column as a Feature because the timestamp does not really affect how a user rates a given movie and thus would not contribute to making a more accurate prediction:
         */
    }
}
