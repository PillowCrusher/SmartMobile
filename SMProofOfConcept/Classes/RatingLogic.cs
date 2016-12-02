
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMProofOfConcept.Classes
{
    class RatingLogic
    {
        /**
	 * 
	 * @param category
	 */
        private List<Rating> ratingList;

        public RatingLogic()
        {
            ratingList = new List<Rating>();
        }

        public void refreshRatingsList(List<Rating> ratings)
        {
            ratingList.Clear();
            ratingList.AddRange(ratings);
        }
           
        public double getRating(CategoryType category)
        {
            double avgRating = 0;
            List<Rating> avgRatings = new List<Rating>();
            foreach (Rating rating in ratingList)
            {
                if (rating.category == category)
                {
                    avgRatings.Add(rating);
                }
            }
            foreach (Rating tempRating in avgRatings)
            {
                avgRating += tempRating.rating;
            }
            if (avgRatings.Count != 0)
            {
                return avgRating/avgRatings.Count;
            }
            return 0;
        }

        public double getAverage()
        {
            double ratingAvg = 0;
            foreach (Rating rating in ratingList)
            {
                ratingAvg += rating.rating;
            }
            return ratingAvg/ratingList.Count;
        }

    }
}
