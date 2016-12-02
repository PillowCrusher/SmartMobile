using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            return var.Replace(" ", "%20");
        }

        /**
         * 
         * @param query
         */
        public string sendQuery(string query)
        {
            string querySend = queryBuilder(query);

            try
            {
                using (WebClient wc = new WebClient())
                {
                    string jsonString = wc.DownloadString("http://i291343.iris.fhict.nl/database.php?query=SELECT*FROM ProductData");
                    convertJson(jsonString);
                }
            }
            catch (Exception)
            {

            }
            return null;
        }

    

        /**
         * 
         * @param Json
         */
        private List<Rating> convertJson(string Json)
        {
            List<Rating> result = new List<Rating>();
            MyClass[] result1 = JsonConvert.DeserializeObject<MyClass[]>(Json);

            return null;
            // TODO - implement DatabaseConnection.convertJson
        }


    }
    public class MyClass
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string ups { get; set; }
        public string downs { get; set; }
    }

}
