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
            
        {   //"https://api.vk.com/method/friends.getOnline?v=5.52&access_token="+

            //WebRequest request = WebRequest.Create("https://api.vk.com/method/friends.get?user_id=201272223&fields=first_name&access_token=f624c346e70d72701dea39f39e08d7b315939f17feab81f4c545fc4c24e2a4d351f26c47054d81b091134&v=5.126");
            // If required by the server, set the credentials.
            //request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Read response
            //StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            //Parse response

            //var parsed = JsonConvert.DeserializeObject<List<JSON_FriendID_online>>(str);

            //Console.WriteLine(parsed[0].first_name);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.vk.com/method/friends.get?user_id=201272223&fields=first_name&access_token=f624c346e70d72701dea39f39e08d7b315939f17feab81f4c545fc4c24e2a4d351f26c47054d81b091134&v=5.126");

            

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream(),Encoding.UTF8);
            
            string result = streamReader.ReadToEnd();

            
            result.Remove(0, 33);
            result.Remove(result.Length - 2,2);
            string rez = result.Remove(0, 33);
            string rez2 = rez.Remove(rez.Length - 2, 2);
            //Console.WriteLine(rez2);
            var rootObject = JsonConvert.DeserializeObject<List<JSON_FriendID_online>>(rez2);

            Console.WriteLine(rootObject[0].first_name);

            httpResponse.Close();

            return rootObject;
            

            
        }

        public void appendFriends (Form2 form)
        {
            
        }

        static void main(String [] args)
        {
            Friend.GetIDFriendsOnline();
        }
    }
}
