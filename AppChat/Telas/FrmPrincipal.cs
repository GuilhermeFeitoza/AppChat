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
        public FrmPrincipal(string ip,string porta, string usuario)
        {
            Ip = ip; 
            Porta = porta;
            usuarioLogado = usuario;
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            // se não esta conectando aguarda a conexão
            if (Conectado == false)
            {
                // Inicializa a conexão
                InicializaConexao();
            }
            else // Se esta conectado entao desconecta
            {
                FechaConexao("Desconectado a pedido do usuário.");
            }
            InitializeComponent();
            
        }
        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado == true)
            {
                // Fecha as conexões, streams, etc...
                Conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();
            }
        }
        private void FechaConexao(string Motivo)
        {
            // Mostra o motivo porque a conexão encerrou
            

            // Fecha os objetos
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();
        }
        private void InicializaConexao()
        {

            // Trata o endereço IP informado em um objeto IPAdress
            enderecoIP = IPAddress.Parse(Ip);
            // Inicia uma nova conexão TCP com o servidor chat
            tcpServidor = new TcpClient();
            if (String.IsNullOrEmpty(Porta))
            {
                tcpServidor.Connect(enderecoIP, 2502);
            }
            else
            {
                tcpServidor.Connect(enderecoIP, Convert.ToInt32(Porta));
            }

            // AJuda a verificar se estamos conectados ou não
            Conectado = true;


            // Envia o nome do usuário ao servidor
            stwEnviador = new StreamWriter(tcpServidor.GetStream());
            stwEnviador.WriteLine(usuarioLogado);
            stwEnviador.Flush();

            //Inicia a thread para receber mensagens e nova comunicação
            mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
            mensagemThread.Start();
        }
        private void AtualizaLog(string strMensagem)
        {
            // Anexa texto ao final de cada linha
           
        }
        private void RecebeMensagens()
        {
            // recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            // Se o primeiro caracater da resposta é 1 a conexão foi feita com sucesso
            if (ConResposta[0] == '1')
            {
                // Atualiza o formulário para informar que esta conectado
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            else // Se o primeiro caractere não for 1 a conexão falhou
            {
                string Motivo = "Não Conectado: ";
                // Extrai o motivo da mensagem resposta. O motivo começa no 3o caractere
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                // Atualiza o formulário como o motivo da falha na conexão
                this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { Motivo });
                // Sai do método
                return;
            }

            // Enquanto estiver conectado le as linhas que estão chegando do servidor
            while (Conectado)
            {
                // exibe mensagems no Textbox
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
            }
        }

        private void pbEnviar_Click(object sender, EventArgs e)
        {

        }
        private string NomeUsuario = "Desconhecido";
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        // Necessário para atualizar o formulário com mensagens da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        // Necessário para definir o formulário para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private bool Conectado;
        private void EnviaMensagem()
        {
            if (txtMensagemDigitada.Lines.Length >= 1)
            {   //escreve a mensagem da caixa de texto
                stwEnviador.WriteLine(txtMensagemDigitada.Text);
                stwEnviador.Flush();
                txtMensagemDigitada.Lines = null;
            }
            txtMensagemDigitada.Text = "";
        }


        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviaMensagem();
                txtMensagemDigitada.Clear();
                MessageBox.Show("enviou"); 
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
