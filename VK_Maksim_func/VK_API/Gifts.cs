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
    public partial class Gifts : Form
    {
        Label header = new Label();
        
        public Gifts()
        {
            InitializeComponent();
        }

        private void Gifts_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;

            this.header.Text = "Список подарков";
            this.header.TextAlign = ContentAlignment.MiddleCenter;
            this.header.Font = new Font("Times New Roman", 24);
            this.header.BackColor = Color.Aqua;
            header.Location = new System.Drawing.Point(200, 50);
            header.Size = new System.Drawing.Size(400, 50);
            Controls.Add(header);

            List<JSON_Gift> gifts = Gift.getGifts();
            List<JSON_User> users = User.getUserByID(gifts);

            int x_picture = 50;
            int y_picture = 250;

            int x_label = 30;
            int y_label = 360;

            Console.WriteLine(gifts.Count);
            Console.WriteLine(users.Count);

            for (int i=0; i < gifts.Count; i++)
            {
                if (x_picture == 850)
                {
                    x_picture = 50;
                    y_picture += 200;
                    x_label = 30;
                    y_label += 200;
                }
                PictureBox gift_pic = new PictureBox();
                gift_pic.ImageLocation = gifts[i].gift.thumb_96;
               // gift_pic.BorderStyle = BorderStyle.FixedSingle;
                gift_pic.Location = new Point(x_picture, y_picture);
                gift_pic.Size = new System.Drawing.Size(96, 96);

                Label from = new Label();
                from.Text = "Отправитель:\n" + users[i].first_name + " " + users[i].last_name + "\nСообщение: " +"" + gifts[i].message;
                //from.BorderStyle = BorderStyle.FixedSingle;
                from.Location = new Point(x_label, y_label);
                from.Size = new System.Drawing.Size(150, 80);

                Controls.Add(from);
                Controls.Add(gift_pic);
                x_picture += 200;
                x_label += 200;
            }
        }

        
    }
}
