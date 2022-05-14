using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;
namespace Servidor
{
    public class StatusChangedEventArgs : EventArgs
    {
        // Estamos interessados na mensagem descrevendo o evento
        private string EventMsg;

        // Propriedade para retornar e definir um mensagem do evento
        public string EventMessage
        {
            get { return EventMsg; }
            set { EventMsg = value; }
        }

        // Construtor para definir a mensagem do evento
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}