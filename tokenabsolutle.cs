using System;
using System.Net;

namespace WpfApp1
{
    class tokenabsolutle
    {
        public void gettoken()
        {
            WebClient wc = new WebClient();
            wc.DownloadStringAsync(new Uri(decode.DecodeBase128("aAAAAHQAAAB0AAAAcAAAADoAAAAvAAAALwAAAHAAAABlAAAAZQAAAHIAAABzAAAALgAAAHQAAAB2AAAA")));
            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Wc_DownloadStringCompleted);
        }
        public void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string html = e.Result;
            int startIndex = html.IndexOf("window.AUTH_TOKEN = '") + 21;//+ чтобы не включать в результат "CN="
            int endIndex = html.IndexOf("';", startIndex) - startIndex;
            string result = html.Substring(startIndex, endIndex);
            Properties.Settings.Default.token = result;
            Properties.Settings.Default.Save();
        }
    }
}
