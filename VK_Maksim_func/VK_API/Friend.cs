using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace VK_API
{
    public class Friend
    {




        public static List<JSON_FriendID_online> GetIDFriendsOnline()
            
        {   
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.vk.com/method/friends.get?fields=first_name,photo_100&access_token=f624c346e70d72701dea39f39e08d7b315939f17feab81f4c545fc4c24e2a4d351f26c47054d81b091134&v=5.126");

            

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(),Encoding.UTF8);
            
            string result = streamReader.ReadToEnd();

            
            result = result.Remove(0, 33);
            result = result.Remove(result.Length - 2, 2);
            
            //Console.WriteLine(rez2);
            var rootObject = JsonConvert.DeserializeObject<List<JSON_FriendID_online>>(result);

            Console.WriteLine(rootObject[0].photo_100);

            httpResponse.Close();

            return rootObject;
            

            
        }

        

        static void main(String [] args)
        {
            Friend.GetIDFriendsOnline();
        }
    }
}
