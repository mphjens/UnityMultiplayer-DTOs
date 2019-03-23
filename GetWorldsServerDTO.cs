using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{

    public class WorldDTO : IDarkRiftSerializable
    {
        public string WorldName;
        public int NrPlayers;
        public int MaxNrPlayers;
        public ushort SceneEntityID;
        public string SceneName;

        public void Deserialize(DeserializeEvent e)
        {
            WorldName = e.Reader.ReadString();
            NrPlayers = e.Reader.ReadInt32();
            MaxNrPlayers = e.Reader.ReadInt32();
            SceneEntityID = e.Reader.ReadUInt16();
            SceneName = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(WorldName);
            e.Writer.Write(NrPlayers);
            e.Writer.Write(MaxNrPlayers);
            e.Writer.Write(SceneEntityID);
            e.Writer.Write(SceneName);
        }
    }

    public class GetWorldsServerDTO : IDarkRiftSerializable
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
