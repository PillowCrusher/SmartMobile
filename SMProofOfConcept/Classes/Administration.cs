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
        private string naam;
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

        /**
         * 
         * @param category
         */
        public string getRatingCategory(CategoryType category)
        {
            return ratingLogic.getRating(category).ToString("0.0");        
        }

        /**
         * 
         * @param naam
         */
        public void getRatingsDatabase(string naam)
        {
            ratingLogic.refreshRatingsList(dbCon.sendQuery("SELECT * FROM SMRatings WHERE Name = '" + naam + "'"));
        }

        private void sendRatingsDatabase()
        {
            // TODO - implement Administration.sendRatingsDatabase
            
        }

    }
}
