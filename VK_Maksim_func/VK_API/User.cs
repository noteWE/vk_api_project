using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VK_API
{
    class User
    {
        public static List<JSON_User> getUserByID(List<JSON_Gift> gifts)
        {

            List<string> ids = new List<string>();
            
            
            for (int i = 0; i < gifts.Count; i++)
            {
                
                 ids.Add(gifts[i].from_id);
                
            }

            string idsForRequest = "";
            for (int i = 0; i < ids.Count; i++)
            {              
                idsForRequest += ids[i] + ",";
            }

            //delete last comma
            idsForRequest.Remove(idsForRequest.Length - 1, 1);
            //get json
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.vk.com/method/users.get?user_ids=" + idsForRequest +"&access_token=f624c346e70d72701dea39f39e08d7b315939f17feab81f4c545fc4c24e2a4d351f26c47054d81b091134&v=5.56");
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
            string result = streamReader.ReadToEnd();

            //update json for next deserialize
            result = result.Remove(0, 12);
            result = result.Remove(result.Length - 1, 1);
           
            //parse json
            var rootObject = JsonConvert.DeserializeObject<List<JSON_User>>(result);
            
            httpResponse.Close();

            //final
            List<JSON_User> final = new List<JSON_User>();

            //for id where is first symbol "-"
            JSON_User community = new JSON_User();
            community.first_name = "Community";

            
            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i].Contains("-"))
                {
                    final.Add(community);
                    i++;
                }
                for (int j = 0; j < rootObject.Count; j++)
                {
                    if (ids[i] == rootObject[j].id)
                    {
                        final.Add(rootObject[j]);
                    }
                }
            }
            
            return final;
        }
    }

    
    
    class FinalNames
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
