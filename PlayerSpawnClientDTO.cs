using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class PlayerSpawnClientDTO : IDarkRiftSerializable
    {
        public ushort entityID;

        public void Deserialize(DeserializeEvent e)
        {
            entityID = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(entityID);
        }
    }
}
