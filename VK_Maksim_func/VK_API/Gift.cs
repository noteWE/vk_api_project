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
    class Gift
    {
        
        public static List<JSON_Gift>  getGifts (string token)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.vk.com/method/gifts.get?&access_token=" + token + "&v=5.126");
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
            string result = streamReader.ReadToEnd();

            //update json
            result = result.Remove(0, result.IndexOf('['));
            result  = result.Remove(result.Length - 2, 2);

            //parse json
            var rootObject = JsonConvert.DeserializeObject<List<JSON_Gift>>(result);

            httpResponse.Close();

            return rootObject;
        }

        
        
    }
}
