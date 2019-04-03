using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class PlayerSpawnClientDTO : IDarkRiftSerializable
    {
        public ushort entityID;
        public UMVector3 position;
        public UMVector3 rotation;

        public void Deserialize(DeserializeEvent e)
        {
            entityID = e.Reader.ReadUInt16();
            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(entityID);
            e.Writer.Write(position.x); e.Writer.Write(position.y); e.Writer.Write(position.z);
            e.Writer.Write(rotation.x); e.Writer.Write(rotation.y); e.Writer.Write(rotation.z);
        }
    }
}
