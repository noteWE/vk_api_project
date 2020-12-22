using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VK_API
{
    public partial class ProfilePage : Form
    {

        string token;

        public ProfilePage(string token)
        {
            this.token = token;
            InitializeComponent();

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            VkApi api = new VkApi();
            api.SetLanguage(Language.Ru);

            if (token == null)
            {
                MessageBox.Show("Нет токена!");
            }
                api.Authorize(new ApiAuthParams { AccessToken = /*"aae9332b9ea96523819906688635238a91fa4b881b25f7e651e2dece973d5e21975e68544d9f6e5a9dc81"*/ token });

                var user = api.Users.Get(
                    new long[0],
                    ProfileFields.PhotoId |
                    ProfileFields.Status |
                    ProfileFields.Photo200 |
                    ProfileFields.BirthDate |
                    ProfileFields.City |
                    ProfileFields.FollowersCount).FirstOrDefault();

                label1.Text = user.FirstName + " " + user.LastName;
                label2.Text = user.Status;
                label5.Text = "Город: " + user.City.Title;
                label4.Text = "Дата рождения: " + user.BirthDate;

                pictureBox1.Load(user.Photo200.ToString());
                pictureBox2.Load("F:\\vk_api_project\\VK_Maksim_func\\VK_API\\sprites\\sprite_like.png");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                PhotoGetParams @params = new PhotoGetParams();
                @params.OwnerId = user.Id;
                int start = user.PhotoId.IndexOf("_") + 1;
                int len = user.PhotoId.Length - start;
                @params.PhotoIds = new string[] { user.PhotoId.Substring(start, len) };
                @params.AlbumId = PhotoAlbumType.Profile;
                @params.Extended = true;

                var photo = api.Photo.Get(@params).FirstOrDefault();

                label3.Text = photo.Likes.Count.ToString();

                FriendsGetParams @paramsFriend = new FriendsGetParams();
                var friends = api.Friends.Get(@paramsFriend);

                label6.Text = "Друзей: " + friends.Count;
                label7.Text = "Подписчиков: " + user.FollowersCount.ToString();
        }
    }
}
