using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_API
{
    public partial class Form2 : Form
    {
        Label header = new Label();
        string token;


        public Form2(string token)
        {
            this.token = token;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //scroll form
            this.AutoScroll = true;
            //header creation
            this.header.Text = "Список друзей";
            this.header.TextAlign = ContentAlignment.MiddleCenter;
            this.header.Font = new Font("Arial", 24);
            this.header.BackColor = Color.Aqua;
            header.Location = new System.Drawing.Point(200, 50);
            header.Size = new System.Drawing.Size(400, 50);
            Controls.Add(header);

            List<JSON_FriendID_online> friends = Friend.GetIDFriendsOnline(token);
            //coords for labels
            
            
            int x_picture = 50;
            int y_picture = 250;

            int x_label = 30;
            int y_label = 360;

            for (int i = 0; i < friends.Count; i++)
            {
                if (x_picture == 850)
                {
                    x_picture = 50;
                    y_picture += 200;
                    x_label = 30;
                    y_label += 200;
                }
                PictureBox friends_pic = new PictureBox();
                friends_pic.ImageLocation = friends[i].photo_100;
                // gift_pic.BorderStyle = BorderStyle.FixedSingle;
                friends_pic.Location = new Point(x_picture, y_picture);
                friends_pic.Size = new System.Drawing.Size(96, 96);

                Label from = new Label();
                from.Text =  friends[i].first_name + " " + friends[i].last_name;
                //from.BorderStyle = BorderStyle.FixedSingle;
                from.Font = new Font("Consoles", 12);
                from.Location = new Point(x_label, y_label);
                from.Size = new System.Drawing.Size(150, 80);

                Controls.Add(from);
                Controls.Add(friends_pic);
                x_picture += 200;
                x_label += 200;
            }
        }

        

        
    }
}
