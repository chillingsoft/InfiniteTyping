namespace InfiniteTyping
{
    public partial class InfiniteTyping : Form
    {
        public InfiniteTyping()
        {
            InitializeComponent();

            string authToken = textToken.Text;
            string serverID = textBoxServer.Text;
            string channelID = textBoxChannel.Text;

            buttonCopy.Click += new EventHandler(buttonCopy_Click);
            buttonRefresh.Click += new EventHandler(buttonRefresh_Click);

            void buttonRefresh_Click(Object sender, EventArgs e)
            {
                string authToken = textToken.Text;
                string serverID = textBoxServer.Text;
                string channelID = textBoxChannel.Text;
                string JsCode = "function infTyping() {\r\nfetch(\"https://discord.com/api/v9/channels/" + channelID + "/typing\", {\r\n    \"credentials\": \"include\",\r\n    \"headers\": {\r\n        \"User-Agent\": \"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:105.0) Gecko/20100101 Firefox/105.0\",\r\n        \"Accept\": \"*/*\",\r\n        \"Accept-Language\": \"en-US,en;q=0.5\",\r\n        \"Authorization\": \"" + authToken + "\",\r\n        \"Alt-Used\": \"discord.com\",\r\n        \"Sec-Fetch-Dest\": \"empty\",\r\n        \"Sec-Fetch-Mode\": \"cors\",\r\n        \"Sec-Fetch-Site\": \"same-origin\"\r\n    },\r\n    \"referrer\": \"https://discord.com/channels/" + serverID + channelID + "\",\r\n    \"referrerPolicy\": \"no-referrer-when-downgrade\",\r\n    \"body\": null,\r\n    \"method\": \"POST\",\r\n    \"mode\": \"cors\"\r\n});\r\n\r\nsetTimeout( function() { infTyping(); }, 8000);\r\n}\r\n\r\ninfTyping()\r\n";
                logTextBox.Clear();
                logTextBox.AppendText(JsCode);
            }

            void buttonCopy_Click(Object sender, EventArgs e)
            {
                string authToken = textToken.Text;
                string serverID = textBoxServer.Text;
                string channelID = textBoxChannel.Text;
                string JsCode = "function infTyping() {\r\nfetch(\"https://discord.com/api/v9/channels/" + channelID + "/typing\", {\r\n    \"credentials\": \"include\",\r\n    \"headers\": {\r\n        \"User-Agent\": \"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:105.0) Gecko/20100101 Firefox/105.0\",\r\n        \"Accept\": \"*/*\",\r\n        \"Accept-Language\": \"en-US,en;q=0.5\",\r\n        \"Authorization\": \"" + authToken + "\",\r\n        \"Alt-Used\": \"discord.com\",\r\n        \"Sec-Fetch-Dest\": \"empty\",\r\n        \"Sec-Fetch-Mode\": \"cors\",\r\n        \"Sec-Fetch-Site\": \"same-origin\"\r\n    },\r\n    \"referrer\": \"https://discord.com/channels/" + serverID + channelID + "\",\r\n    \"referrerPolicy\": \"no-referrer-when-downgrade\",\r\n    \"body\": null,\r\n    \"method\": \"POST\",\r\n    \"mode\": \"cors\"\r\n});\r\n\r\nsetTimeout( function() { infTyping(); }, 8000);\r\n}\r\n\r\ninfTyping()\r\n";
                logTextBox.Clear();
                logTextBox.AppendText(JsCode);
                Clipboard.SetText(JsCode);

            }
        }

        private void InfiniteTyping_Load(object sender, EventArgs e)
        {

        }
    }
}