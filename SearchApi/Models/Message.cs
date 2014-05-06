using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModels
{
    public enum MessageType
    {
        Error,
        Warning, 
        Info
    }

    public class Message
    {
        public string Text { get; set; }

        public MessageType MessageType { get; set; }
    }
}
