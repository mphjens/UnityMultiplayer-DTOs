using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class UseEntityClientDTO : IDarkRiftSerializable
    {
        public uint id;

        public void Deserialize(DeserializeEvent e)
        {
            id = e.Reader.ReadUInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(id);
        }
    }

    public class UseEntityServerDTO : IDarkRiftSerializable
    {
        public uint id;
        public ushort PlayerID;

        public void Deserialize(DeserializeEvent e)
        {
            id = e.Reader.ReadUInt32();
            PlayerID = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(id);
            e.Writer.Write(PlayerID);
        }
    }
}
