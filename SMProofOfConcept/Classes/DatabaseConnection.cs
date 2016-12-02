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
        public string sendQuery(string query)
        {
            string jsonString = "";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    jsonString = wc.DownloadString(query);
                }
            }
            catch(Exception e)
            {
                
            }
            return jsonString;
        }

        /**
         * 
         * @param Json
         */
        private string convertJson(string Json)
        {
          List<Rating> result = JsonConvert.DeserializeObject<Rating[]>(Json);
            
        }

    }
}
