using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class PlayerSpawnServerDTO : IDarkRiftSerializable
    {
        public ushort ID;
        public ushort entityID;

        public UMVector3 position;
        public UMVector3 rotation;
        public float health;
        

        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadUInt16();
            entityID = e.Reader.ReadUInt16();

            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());

            health = e.Reader.ReadSingle();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(entityID);

            e.Writer.Write(this.position.x); e.Writer.Write(this.position.y); e.Writer.Write(this.position.z);
            e.Writer.Write(this.rotation.x); e.Writer.Write(this.rotation.y); e.Writer.Write(this.rotation.z);

            e.Writer.Write(health);
            
        }
    }
}
