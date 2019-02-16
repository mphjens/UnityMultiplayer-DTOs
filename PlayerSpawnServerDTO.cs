using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class PlayerSpawnServerDTO : IDarkRiftSerializable
    {
        public ushort ID;
        public ushort entityID;

        public float x, y, z;
        public float health;
        

        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadUInt16();
            entityID = e.Reader.ReadUInt16();

            x = e.Reader.ReadSingle();
            y = e.Reader.ReadSingle();
            z = e.Reader.ReadSingle();

            health = e.Reader.ReadSingle();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(entityID);

            e.Writer.Write(x);
            e.Writer.Write(y);
            e.Writer.Write(z);

            e.Writer.Write(health);
            
        }
    }
}
