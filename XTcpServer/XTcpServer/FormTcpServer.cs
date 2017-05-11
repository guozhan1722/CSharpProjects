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
using System.IO;

namespace XTcpServer
{
    public partial class FormTcpServer : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;

        public FormTcpServer()
        {
            InitializeComponent();
            IPAddress[] address = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress ad in address)
            {
                if(ad.AddressFamily == AddressFamily.InterNetwork)
                {
                    textBoxIP.Text = ad.ToString();
                    textBoxIP.Enabled = false;
                    break;
                }
            }
            textBoxMessages.AppendText("Server started up, waiting for Connection ...\n");
            backgroundWorkerStart.RunWorkerAsync();
        }

        private void backgroundWorkerRecieve_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while(client.Connected)
            {
                try
                {
                    String recievedText = reader.ReadLine();
                    worker.ReportProgress(1, recievedText);
                    recievedText = "";
                }
                catch (Exception ex)
                {
                }
            }
            client.Close();
            e.Result = "Disconnected !\n";
        }

        private void backgroundWorkerRecieve_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            String rxText = (String)e.UserState;
            textBoxMessages.AppendText("Client: " + rxText + "\n");
        }

        private void backgroundWorkerRecieve_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxMessages.AppendText((String)e.Result);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if((client == null) || !client.Connected)
            {
               textBoxMessages.AppendText("Cannot send message, no connection \n");
               textBoxSend.Text="";
                return;
            }

            try
            {
                String txText = textBoxSend.Text;
                    writer.WriteLine(txText);
                    textBoxMessages.AppendText("Server: " + txText + "\n");
                    textBoxSend.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        private void backgroundWorkerStart_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textBoxPort.Text));
                listener.Start();
                client = listener.AcceptTcpClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorkerStart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                textBoxMessages.AppendText("Connected with client! \n");
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                writer.AutoFlush = true;

                backgroundWorkerRecieve.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

    }
}
