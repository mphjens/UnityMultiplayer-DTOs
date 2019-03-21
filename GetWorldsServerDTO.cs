using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{

    class WorldDTO : IDarkRiftSerializable
    {
        public string WorldName;
        public ushort SceneEntityID;

        public void Deserialize(DeserializeEvent e)
        {
            WorldName = e.Reader.ReadString();
            SceneEntityID = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(WorldName);
            e.Writer.Write(SceneEntityID);
        }
    }

    class GetWorldsServerDTO : IDarkRiftSerializable
    {
        public WorldDTO[] Worlds;

        public void Deserialize(DeserializeEvent e)
        {
            Worlds = e.Reader.ReadSerializables<WorldDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(Worlds);
        }
    }
}
