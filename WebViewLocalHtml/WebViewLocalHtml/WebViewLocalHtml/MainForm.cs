using System;
using Eto.Forms;
using Eto.Drawing;

namespace WebViewLocalHtml
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Title = "WebView https://ace.c9.io/build/kitchen-sink.html";
            ClientSize = new Size(400, 350);
            WebView webView = new WebView() { Url=new Uri("https://ace.c9.io/build/kitchen-sink.html") };

            DynamicLayout layout = new DynamicLayout();
            layout.Add(webView);
            Content = layout;
        }
    }
}
