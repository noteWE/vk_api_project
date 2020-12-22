using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_API
{
    public partial class FunctionPage : Form
    {
        string token;

        public FunctionPage()
        {
            InitializeComponent();
        }

        private void FunctionPage_Load(object sender, EventArgs e)
        {
            Upload();
        }

        private void Upload()
        {
            pictureBox1.Load("..\\..\\sprites\\logo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string info = "";
            string fileName = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile) + "\\Documents\\token.txt";
            if (File.Exists(fileName))
            {
                info = File.ReadAllLines("C:\\Users\\AV3N\\Documents\\token.txt").FirstOrDefault();
                int ind = info.IndexOf('|');
                string token = info.Substring(ind + 1, info.Length - ind - 1);
                string date = info.Substring(0, ind);
                DateTime dt = DateTime.Parse(date);
                var period = DateTime.Now.CompareTo(dt.AddDays(1));

                if (period >= 0)
                {
                    chencheView(false);
                } else
                {
                    chencheView(true);
                    this.token = token;
                }
            }
            else
            {
                chencheView(false);
            }
        }

        private void chencheView(bool check)
        {
            if (!check)
            {
                label1.Text = "Действие токена прекратилось, авторизуйтесь заново";
                Button updateButton = new Button();
                button1.Visible = true;
                button6.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }
            else
            {
                label1.Text = "";
                button1.Visible = false;
                button6.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(token);
            profilePage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gifts gifts = new Gifts(token);
            gifts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(token);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrowserPage browserPage = new BrowserPage();
            browserPage.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Upload();
            Refresh();
        }
    }
}
