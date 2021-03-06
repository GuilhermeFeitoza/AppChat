using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Net;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable();
        List<TcpClient> listConnectedClients = new List<TcpClient>();
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o IP desejado");
            TcpListener serverSocket = new TcpListener(IPAddress.Parse(Console.ReadLine()), 8888);
            TcpClient clientSocket = default(TcpClient);

            int counter = 0;

            serverSocket.Start();
            Console.WriteLine("Servidor iniciado ....");
            counter = 0;
            while ((true))
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                dataFromClient = System.Text.Encoding.UTF8.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                clientsList.Add(dataFromClient, clientSocket);

                broadcast(dataFromClient + " Entrou ", dataFromClient, false,false);

                Console.WriteLine(dataFromClient + " Entrou na sala ");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, dataFromClient, clientsList);
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine("exit");
            Console.ReadLine();
        }

        public static void broadcast(string msg, string uName, bool flag ,bool arquivo)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    if (msg.Contains(":") && msg.Contains("\\"))
                    {
                        broadcastBytes = Encoding.UTF8.GetBytes(uName + " Enviou o arquivo : " + msg);

                    }
                    else {

                        broadcastBytes = Encoding.UTF8.GetBytes(uName + " disse : " + msg);
                    }
                  
                }
                else
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(msg);
                }
           

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }  //end broadcast function
    }//end Main class


    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        Hashtable clientsList;

        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }

        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    dataFromClient = System.Text.Encoding.UTF8.GetString(bytesFrom);
                    if (dataFromClient.Contains("$"))
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                        Console.WriteLine("do client - " + clNo + " : " + dataFromClient);
                        rCount = Convert.ToString(requestCount);
                        Program.broadcast(dataFromClient, clNo, true,false);
                    }
                    else if (dataFromClient.Contains("|")) {

                        //dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("|"));

                        Console.WriteLine("arquivo recebido - " + clNo + " : " + dataFromClient);
                        rCount = Convert.ToString(requestCount);
                        Program.broadcast(dataFromClient, clNo, false,true);


                    }
                    else
                    {


                        Program.broadcast(dataFromClient, clNo, true,false);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }//end while
        }//end doChat
    }
}