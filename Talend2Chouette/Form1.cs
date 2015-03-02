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
using System.Net;

namespace Talend2Chouette
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        string nbJours;
        string datedujour = DateTime.Now.ToString("ddMMyy/HHmm");
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DateFin_ValueChanged(object sender, EventArgs e)
        {
            int i = NbDeJours(DateDebut.Value, DateFin.Value);
            nbJours = Convert.ToString(i);
            Lab_NbDeJour.Text = nbJours + " Jours";
        }
        public int NbDeJours(DateTime Debut, DateTime Fin)
        {
            TimeSpan difference = Fin.Date - Debut.Date;
            int resultat = difference.Days;
            return resultat;
        }

        private void DateDebut_ValueChanged(object sender, EventArgs e)
        {
            int i = NbDeJours(DateDebut.Value, DateFin.Value);
            nbJours = Convert.ToString(i);
            Lab_NbDeJour.Text = nbJours + " Jours";
        }

        private void Chk_Purge_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Purge.Checked == true)
            {
                Lab_Purge.Text = "Purger";
            }
            else
            {
                Lab_Purge.Text = "Non Purger";
            }
        }

        private void Txt_Filename_Leave(object sender, EventArgs e)
        {
            string valeur = Txt_Filename.Text;
            if (valeur.IndexOf(".zip") != -1)
            {
                MessageBox.Show("Ne pas mettre le \".zip\"");
            }
            Lab_Filename.Text = datedujour + "-" + Txt_Filename.Text;
        }

        private void Btn_ValideImport_Click(object sender, EventArgs e)
        {
            progressImport.Value = 100;
            if (Chk_Purge.Checked == false)
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes("import$ImportSansPurge$" + DateDebut.Value.ToString("dd/MM/yy") + "$" + nbJours + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] bytesFrom = new byte[10025];
                serverStream.Read(bytesFrom, 0, Convert.ToInt32(clientSocket.ReceiveBufferSize));
                string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                string dataFromClientok = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                if (dataFromClientok == "ok")
                {
                    MessageBox.Show("Le Job a bien été lancé !", "Super !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Il y'a un problème avec le job !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes("import$ImportPurge$" + DateDebut.Value.ToString("dd/MM/yy") + "$" + nbJours + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] bytesFrom = new byte[10025];
                serverStream.Read(bytesFrom, 0, Convert.ToInt32(clientSocket.ReceiveBufferSize));
                string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                string dataFromClientok = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                if (dataFromClientok == "ok")
                {
                    MessageBox.Show("Le Job a bien été lancé !", "Super !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Il y'a un problème avec le job !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Combo_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lab_Format.Text = Combo_Format.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clientSocket.Connect("192.168.207.20", 9449);
            clientSocket.Connect("127.0.0.1", 9449);
            Combo_Format.SelectedItem = "NEPTUNE";
        }

        private void Btn_ValideExport_Click(object sender, EventArgs e)
        {
            Lab_Filename.Text = datedujour + "-" + Txt_Filename.Text;
            progressExport.Value = 100;
            string FormatExport = Combo_Format.Text;
            string NomduFichier = Lab_Filename.Text;

            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("export$" + FormatExport + "$" + NomduFichier + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] bytesFrom = new byte[10025];
            serverStream.Read(bytesFrom, 0, Convert.ToInt32(clientSocket.ReceiveBufferSize));
            string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
            string dataFromClientok = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
            if (dataFromClientok == "ok")
            {
                MessageBox.Show("Le Job a bien été lancé !", "Super !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Il y'a un problème avec le job !", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_OpenExport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"\\SDDMEDKPATALEND\Exports$");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket.Close();
        }
    }
}
