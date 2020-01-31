using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class PlayerSpawnClientDTO : IDarkRiftSerializable
    {
        public ushort PlayerID; //Only used in AI players.  Otherwise Client.ID is used. Before client recieves id, send 0. TODO: Find a better way to do this.
        public ushort entityID;
        public UMVector3 position;
        public UMVector3 rotation;
        public bool isAI;

        public void Deserialize(DeserializeEvent e)
        {
            PlayerID = e.Reader.ReadUInt16();
            entityID = e.Reader.ReadUInt16();
            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            isAI = e.Reader.ReadBoolean();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(PlayerID);
            e.Writer.Write(entityID);
            e.Writer.Write(position.x); e.Writer.Write(position.y); e.Writer.Write(position.z);
            e.Writer.Write(rotation.x); e.Writer.Write(rotation.y); e.Writer.Write(rotation.z);
            e.Writer.Write(isAI);
        }
    }
}
