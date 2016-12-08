using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace SMProofOfConcept.Classes
{
    class DatabaseConnection
    {
        /**
	 * 
	 * @param var
	 */
        private string queryBuilder(string var)
        {
            //http://i291343.iris.fhict.nl/database.php?query=SELECT*FROM%20SMRatings
            return var.Replace(" ", "%20");
        }


        /**
         * 
         * @param query
         */
        public List<Rating> sendQuery(string query)
        {
            string querySend = "http://i291343.iris.fhict.nl/database.php?query=" + queryBuilder(query);
            string jsonString = "";
            List<Rating> result = new List<Rating>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    jsonString = wc.DownloadString(querySend);
                    result = convertJson(jsonString);
                }
            }
            catch(Exception)
            {
                
            }
            return result;
        }

        /**
         * 
         * @param Json
         */
        private List<Rating> convertJson(string jsonString)
        {
            List<Rating> result = new List<Rating>();
            DatabaseRating[] dbRating = JsonConvert.DeserializeObject<DatabaseRating[]>(jsonString);
            CategoryType type;

            foreach(DatabaseRating r in dbRating)
            {
                Enum.TryParse(r.Category, out type);
                string convertedRating = r.Rating.Replace(".", ",");
                result.Add(new Rating(type, Convert.ToDouble(convertedRating), DateTime.Parse(r.DateTime)));
            }

            return result;
        }

    }

    public class DatabaseRating
    {
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Category { get; set; }
        public string DateTime { get; set; }
    }
}
