using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener serverSocket = new TcpListener(9449);
        TcpClient clientSocket = default(TcpClient);
        Thread listens;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {   
                NotifyIcon.Visible = true;
                NotifyIcon.BalloonTipTitle = "Talend2Chouette Server";
                NotifyIcon.BalloonTipText = "L'application ce trouve ici !";
                NotifyIcon.ShowBalloonTip(500);
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                NotifyIcon.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listens = new Thread(new ThreadStart(Connect));
            listens.IsBackground = true;
            listens.Start();
        }
        private void Connect()
        {
            serverSocket.Start();
            clientSocket = serverSocket.AcceptTcpClient();
            NetworkStream networkStream = clientSocket.GetStream();
            byte[] bytesFrom = new byte[10025];
            networkStream.Read(bytesFrom, 0, Convert.ToInt32(clientSocket.ReceiveBufferSize));
            string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
            string dataFromClientok = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
            string[] spliter = dataFromClient.Split('$');
            try {
                    if (dataFromClientok == "import") // SI c'est import
                    {
                        string Purge = spliter[1];
                        string DateDebut = spliter[2];
                        string nbJours = spliter[3];
                        if (Purge == "ImportPurge") //Si y'a purge
                        {
                            System.Diagnostics.Process.Start(@"C:\Users\talend\Desktop\Jobs\purge\Purge\Purge_run.bat", null); 
                            System.Diagnostics.Process.Start(@"C:\Users\talend\Desktop\Jobs\import\Hastus2Chouette\Hastus2Chouette_run.bat", "--context_param DateDebut=" + DateDebut + " --context_param nbJours=" + nbJours);
                            Byte[] DataAEnvoyer = Encoding.ASCII.GetBytes("ok$");
                            networkStream.Write(DataAEnvoyer, 0, DataAEnvoyer.Length);
                            networkStream.Flush();
                        }
                        else//Si y'a pas purge
                        {
                            System.Diagnostics.Process.Start(@"C:\Users\talend\Desktop\Jobs\import\Hastus2Chouette\Hastus2Chouette_run.bat", "--context_param DateDebut=" + DateDebut + " --context_param nbJours=" + nbJours);
                            Byte[] DataAEnvoyer = Encoding.ASCII.GetBytes("ok$");
                            networkStream.Write(DataAEnvoyer, 0, DataAEnvoyer.Length);
                            networkStream.Flush();
                        }
                    }
                    else //C'est Export
                    {
                        string FormatExport = spliter[1];
                        string NomduFichier = spliter[2];
                        System.Diagnostics.Process.Start(@"C:\Users\talend\Desktop\Jobs\export\ExportChouetteNeptune\ExportChouetteNeptune_run.bat", "--context_param FormatExport=" + FormatExport + " --context_param NameExport=" + NomduFichier+".zip");
                        Byte[] DataAEnvoyer = Encoding.ASCII.GetBytes("ok$");
                        networkStream.Write(DataAEnvoyer, 0, DataAEnvoyer.Length);
                        networkStream.Flush();
                    }
                    serverSocket.Stop();
                    listens.Abort();
            }
            catch (Exception)
                {
                    Byte[] DataAEnvoyer = Encoding.ASCII.GetBytes("pb$");
                    networkStream.Write(DataAEnvoyer, 0, DataAEnvoyer.Length);
                    networkStream.Flush();
                }        
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
