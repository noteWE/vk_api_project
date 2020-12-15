using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK
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
            String token;
            String urlToken = e.Url.ToString();
            try
            {
                token = urlToken.Substring(urlToken.IndexOf("access_token=") + 13, 85);
            }
            catch
            {
                token = "";
            }
            String fileName = "C:\\Users\\AV3N\\Documents\\token.txt";
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
                byte[] tempArr = System.Text.Encoding.UTF8.GetBytes(token);
                fStream.Write(tempArr, 0, tempArr.Length);
            }
        }
    }
}
