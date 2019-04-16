using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class LoginClientDTO : IDarkRiftSerializable
    {
        public string username { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            username = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(username);
        }
    }

    public class LoginServerDTO : IDarkRiftSerializable
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public void Deserialize(DeserializeEvent e)
        {
            Success = e.Reader.ReadBoolean();
            Message = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Success);
            e.Writer.Write(Message);
        }
    }

}
