using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class JoinWorldClientDTO : IDarkRiftSerializable
    {
        public string WorldName;

        public void Deserialize(DeserializeEvent e)
        {
            WorldName = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(WorldName);
        }
    }

    class JoinWorldServerDTO : IDarkRiftSerializable
    {
        public bool Success;
        public string Message;

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
