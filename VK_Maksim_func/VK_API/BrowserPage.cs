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
using VkNet;
using VkNet.Model;

namespace VK_API
{
    public partial class BrowserPage : Form
    {
        public BrowserPage()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=7655169&scope=215986143&redirect_uri=https://oauth.vk.com/blank.html&display=page&response_type=token&revoke=1");
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentComplited);
        }

        private void webBrowser1_DocumentComplited(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string token;
            string urlToken = e.Url.ToString();
            int ind = urlToken.IndexOf("access_token=");
            if (ind != -1)
            {
                token = urlToken.Substring(urlToken.IndexOf("access_token=") + 13, 85);
            }
            else
            {
                return;
            }
            string fileName = "C:\\Users\\AV3N\\Documents\\token.txt";
            try
            {
                FileInfo tokenFile = new FileInfo(fileName);
                if (!(tokenFile.Exists))
                    tokenFile.Create();
            }
            catch
            {

            }
            using (FileStream fStream = new FileStream(fileName, FileMode.Open))
            {
                DateTime dt = DateTime.Now;
                byte[] tempArr = System.Text.Encoding.UTF8.GetBytes(dt.ToString() + "|" + token);
                fStream.Write(tempArr, 0, tempArr.Length);
            }
            Close();
            Close();
        }
    }
}
