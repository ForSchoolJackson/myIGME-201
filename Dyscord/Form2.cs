using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace Dyscord
{
    //create delegate
    public delegate void UpdateConversationDelegate(string text);

    public partial class DyscordForm : Form
    {

        string targetUser = "";
        string targetIp = "";
        int targetPort;
        string myIp = "";
        int myPort = 2222;
        Thread thread;
        Socket listener;
        public DyscordForm()
        {
            InitializeComponent();

            
            this.Show();

            SettingsForm settingsForm = new SettingsForm(this, myPort);
            settingsForm.ShowDialog();
            this.myPort = settingsForm.myPort;

            //use thread to listen for messages
            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
            thread.Start();

            //set the IP adress of computer
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress iPAddress in ipHost.AddressList)
            {
                if(iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }

            //event handlers
            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.usersButton.Click += new EventHandler(UsersButton__Click);
            this.sendButton.Click += new EventHandler(SendButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);

            this.FormClosing += new FormClosingEventHandler(Form__FormClosing);

        }

        private void LoginButton__Click(object sender, EventArgs e)
        {
            if(userTextBox.TextLength > 0)
            {
                webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?login=" + userTextBox.Text + "&ip=" + myIp + ":" + myPort);
                webBrowser1.Visible = false;
                userTextBox.Enabled = false;
                loginButton.Enabled = false;
            }
        }

        private void UsersButton__Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?logins");
            webBrowser1.Visible = true;
            convRichTextBox.SendToBack();
        }

        //connect to the html in the web browser
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement htmlElement in htmlElementCollection)
            {
                htmlElement.Click += new HtmlElementEventHandler(HtmlElement__Click);
            }
        }

        //if html clicked
        private void HtmlElement__Click(object sender, HtmlElementEventArgs e)
        {
            string title;
            string[] ipPort;

            HtmlElement htmlElement = (HtmlElement)sender;

            title = htmlElement.GetAttribute("title");
            ipPort = title.Split(':');
            this.targetIp = ipPort[0];
            this.targetPort = Int32.Parse(ipPort[1]);

            this.targetUser = htmlElement.GetAttribute("name");
            this.groupBox1.Text = "Conversing with" + targetUser;

            webBrowser1.Visible = false;
            webBrowser1.SendToBack();
        }

        //send the message to the ip adreess
        private void SendButton__Click(object sender, EventArgs e)
        {
            if(this.targetIp.Length > 0)
            {
                IPAddress iPAddress = IPAddress.Parse(this.targetIp);
                IPEndPoint remoteEndPoint = new IPEndPoint(iPAddress, this.targetPort);

                //use socket to connect
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(remoteEndPoint);
                //create network stream
                Stream netStream = new NetworkStream(server);
                //streeam writer to write to the stream
                StreamWriter writer = new StreamWriter(netStream);

                //write maeeseg
                string msg = userTextBox.Text + ": " + msgRichTextBox.Text;
                writer.Write(msg.ToCharArray(), 0, msg.Length);

                //close
                writer.Close();
                netStream.Close();
                server.Close();

                //show it was sent
                this.convRichTextBox.Text += "> " + this.targetUser + ": " + msgRichTextBox.Text + "\n";

                //clear text box
                msgRichTextBox.Clear();

            }
        }
        private void ExitButton__Click(object sender, EventArgs e)
        {
           //clean up 
           listener.Close();
           thread.Abort();

           Application.Exit();
        }

        private void Form__FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Close();
            thread.Abort();

        }
  
        //add message recieved to convo text box
        public void UpdateConversation(string text)
        {
            this.convRichTextBox.Text += (text + "\n");
            //add new line to split messages
        }

        //listen for text messages being sent
        public void Listen()
        {
            //declare delagate
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(UpdateConversation);

            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Any, this.myPort);

            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(serverEndpoint);

            //listens for connects can have 300 max
            listener.Listen(300);

            //stay in infinate loop to listen to connections
            while (true)
            {
                //conncest application senf=ding and recieve message
                Socket client = listener.Accept();
                //connect network strean to client
                Stream netStream = new NetworkStream(client);
                //read data on net stream
                StreamReader reader = new StreamReader(netStream);
                //get whole message and turnb to string
                string result = reader.ReadToEnd();
                
                //use delegate
                Invoke(updateConversationDelegate, result);

                //close things
                reader.Close();
                netStream.Close();
                client.Close();

            }
        }













        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void usersButton_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
