using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMProofOfConcept.Classes;

namespace SMProofOfConcept
{
    public class Administration
    {
        private RatingLogic ratingLogic;
        private DatabaseConnection dbCon;
        public Administration()
        {
            ratingLogic = new RatingLogic();
            dbCon = new DatabaseConnection();
        }

        public string getAvarage()
        {
            return ratingLogic.getAverage().ToString("0.0");
        }

        public string getRatingCategory(CategoryType category)
        {
            return ratingLogic.getRating(category).ToString("0.0");        
        }

        public void getRatingsDatabase(string naam)
        {
            ratingLogic.refreshRatingsList(dbCon.sendQuery("SELECT * FROM SMRatings WHERE Name = '" + naam + "'"));
        }

        public void sendRatingsDatabase(List<Rating> ratings)
        {
            int countdown = ratings.Count;
            //INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')
            string query = "INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (";
            foreach (Rating rating in ratings)
            {
                countdown--;
                if (countdown == 0)
                {
                    query += "NULL, '" + rating.name + "', '" + rating.rating + "', '" + rating.category + "', '" +
                        DateTime.Now + "')";
                }
                else
                {
                    query += "NULL, '" + rating.name + "', '" + rating.rating+ "', '" + rating.category + "', '" +
                        DateTime.Now + "'), (";
                }
               
            }
            dbCon.sendQuery(query);
        }

    }
}
