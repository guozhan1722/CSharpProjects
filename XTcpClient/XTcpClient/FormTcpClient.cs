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


namespace XTcpClient
{
    public partial class FormTcpClient : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;

        public FormTcpClient()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(textBoxIP.Text), int.Parse(textBoxPort.Text));
                if (client.Connected)
                {
                    textBoxMessages.AppendText("Connected with server\n");
                    reader = new StreamReader(client.GetStream());
                    writer = new StreamWriter(client.GetStream());
                    writer.AutoFlush = true;
                    backgroundWorkerRecieve.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorkerRecieve_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (client.Connected)
            {
                try
                {
                    String recievedText = reader.ReadLine();
                    //textBoxMessages.Invoke(new MethodInvoker(delegate(){textBoxMessages.AppendText(recievedText);}));
                    worker.ReportProgress(1, recievedText);
                    recievedText = "";
                }
                catch (Exception ex)
                {
                    ;    
                }
            }
            client.Close();
            e.Result = "Disconnected !\n";
        }

        private void backgroundWorkerRecieve_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            String rxText = (String)e.UserState;
            textBoxMessages.AppendText("Server: " + rxText + "\n");
        }
        private void backgroundWorkerRecieve_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxMessages.AppendText((String)e.Result);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if ((client == null) || !client.Connected)
            {
                textBoxMessages.AppendText("Cannot send message, no connection \n");
                textBoxSend.Text = "";
                return;
            }

            try
            {
                String txText = textBoxSend.Text;
                writer.WriteLine(txText);
                textBoxMessages.AppendText("Client: " + txText + "\n");
                textBoxSend.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
        }

    }
}
