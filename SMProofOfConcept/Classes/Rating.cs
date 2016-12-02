using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMProofOfConcept.Classes
{
    public class Rating
    {

        public CategoryType category { get; set; }
        public double rating { get; set; }
        public DateTime moment { get; set; }

        /**
         * 
         * @param category
         * @param rating
         */
        public Rating(CategoryType category, double rating)
        {
            this.category = category;
            this.rating = rating;
            this.moment = DateTime.Now;
        }

        public Rating(CategoryType category, double rating, DateTime moment)
        {
            this.category = category;
            this.rating = rating;
            this.moment = moment;
        }


            
    }
}
