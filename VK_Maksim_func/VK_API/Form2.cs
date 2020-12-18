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



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //scroll form
            this.AutoScroll = true;
            //header creation
            this.header.Text = "Список друзей онлайн";
            this.header.TextAlign = ContentAlignment.MiddleCenter;
            this.header.Font = new Font("Times New Roman", 24);
            this.header.BackColor = Color.Aqua;
            header.Location = new System.Drawing.Point(200, 50);
            header.Size = new System.Drawing.Size(400, 50);
            Controls.Add(header);

            List<JSON_FriendID_online> friends = Friend.GetIDFriendsOnline();
            //coords for labels
            int x = 300;
            int y = 100;
            
            for (int i = 0; i <friends.Count; i++)
            {
                Label first_name = new Label();
                first_name.Text = (i+1)+"."+friends[i].first_name +" " + friends[i].last_name;
                first_name.Location = new System.Drawing.Point(x, y+=30);
                first_name.Size = new System.Drawing.Size(300, 20);
                
                Controls.Add(first_name);
            }
        }

        

        
    }
}
