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
        //List<JSON_Gift>
        public static List<JSON_Gift>  getGifts ()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.vk.com/method/gifts.get?&access_token=f624c346e70d72701dea39f39e08d7b315939f17feab81f4c545fc4c24e2a4d351f26c47054d81b091134&v=5.126");
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
            string result = streamReader.ReadToEnd();

            //update json
            result = result.Remove(0, 32);
            result  = result.Remove(result.Length - 2, 2);

            //parse json
            var rootObject = JsonConvert.DeserializeObject<List<JSON_Gift>>(result);

            httpResponse.Close();

            return rootObject;
        }

        
        
    }
}
