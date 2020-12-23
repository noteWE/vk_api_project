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
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VK_API
{
    public partial class Groups : Form
    {
        Label header = new Label();
        string token;
        public Groups(string token)
        {
            this.token = token;
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            VkApi api = new VkApi();
            api.SetLanguage(Language.Ru);

            if (token == null) MessageBox.Show("Нет токена!");
            api.Authorize(new ApiAuthParams { AccessToken = token });

            var groups = api.Groups.Get(new GroupsGetParams() { Extended = true }).ToList();
            //MessageBox.Show(groups.Count.ToString());

            this.AutoScroll = true;
            //header creation
            this.header.Text = "Список групп";
            this.header.TextAlign = ContentAlignment.MiddleCenter;
            this.header.Font = new Font("Arial", 24);
            this.header.BackColor = Color.Aqua;
            header.Location = new System.Drawing.Point(200, 50);
            header.Size = new System.Drawing.Size(400, 50);
            Controls.Add(header);

            int x_picture = 50;
            int y_picture = 250;

            int x_label = 30;
            int y_label = 360;

            foreach (var gr in groups)
            {
                if (x_picture == 850)
                {
                    x_picture = 50;
                    y_picture += 200;
                    x_label = 30;
                    y_label += 200;
                }

                PictureBox group_pic = new PictureBox();
                group_pic.ImageLocation = gr.Photo100.ToString();
                group_pic.Location = new Point(x_picture, y_picture);
                group_pic.Size = new System.Drawing.Size(96, 96);

                Label from = new Label();
                from.Text = gr.Name;
                from.Font = new Font("Consoles", 12);
                from.Location = new Point(x_label, y_label);
                from.Size = new System.Drawing.Size(150, 80);

                Controls.Add(from);
                Controls.Add(group_pic);
                x_picture += 200;
                x_label += 200;
            }
        }
    }
}
