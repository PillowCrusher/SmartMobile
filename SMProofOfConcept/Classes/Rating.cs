using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMProofOfConcept.Classes
{
    public class Rating
    {
        public string name { get; set; }
        public CategoryType category { get; set; }
        public double rating { get; set; }
        public DateTime moment { get; set; }

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

        public Rating(string name, CategoryType category, double rating)
        {
            this.name = name;
            this.category = category;
            this.rating = rating;
        }




    }
}
