using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class RemoveComponentDTO : IDarkRiftSerializable
    {
        public uint ComponentID;

        public RemoveComponentDTO()
        {
        }

        public void Deserialize(DeserializeEvent e)
        {
            this.ComponentID = e.Reader.ReadUInt32();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(this.ComponentID);
        }
    }
}