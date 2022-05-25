using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChat.Telas
{
    public partial class FrmPrincipal : Form
    {
        public String Ip;
        public String Porta;
        public String usuarioLogado;
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        public FrmPrincipal(string ip, string porta, string usuario)
        {
            try
            {
                Ip = ip;
                Porta = porta;
                usuarioLogado = usuario;



                // se não esta conectando aguarda a conexão

                InitializeComponent();
                readData = "Conectado ao servidor de chat...";
                msg();


                clientSocket.Connect(IPAddress.Parse(Ip), int.Parse(Porta));
                serverStream = clientSocket.GetStream();

                byte[] outStream = System.Text.Encoding.UTF8.GetBytes(usuarioLogado + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                Thread ctThread = new Thread(getMessage);
                ctThread.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw ex;
            }
           

        }

        private void pbEnviar_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.UTF8.GetBytes(txtMensagemDigitada.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            txtMensagemDigitada.Clear();
            if (hasAttachement) {
                byte[] outStream2 = System.Text.Encoding.UTF8.GetBytes(fileContent);
                serverStream.Write(outStream2, 0, outStream2.Length);
                serverStream.Flush();
            }

        }


        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                byte[] outStream = System.Text.Encoding.UTF8.GetBytes(txtMensagemDigitada.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                txtMensagemDigitada.Clear();
                if (hasAttachement)
                {
                    byte[] outStream2 = System.Text.Encoding.UTF8.GetBytes(fileContent);
                    serverStream.Write(outStream2, 0, outStream2.Length);
                    serverStream.Flush();
                }

                hasAttachement = false;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[1024];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = Encoding.UTF8.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }
        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                txtLog.Text = txtLog.Text + Environment.NewLine + " >> " + readData;
        }
        StreamReader reader;
        bool hasAttachement;
        string filePath;
        string fileContent;

        private void pbAnexo_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();
                        reader = new StreamReader(fileStream);
                        fileContent = reader.ReadToEnd();
                        txtMensagemDigitada.Text = filePath;
                        hasAttachement = true;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
  
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
