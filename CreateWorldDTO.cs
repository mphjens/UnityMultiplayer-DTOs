using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class CreateWorldClientDTO : IDarkRiftSerializable
    {
        public ushort SceneEntityID;
        public string SceneName;
        public string WorldName;


        public void Deserialize(DeserializeEvent e)
        {
            SceneEntityID = e.Reader.ReadUInt16();
            SceneName = e.Reader.ReadString();
            WorldName = e.Reader.ReadString();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(SceneEntityID);
            e.Writer.Write(SceneName);
            e.Writer.Write(WorldName);
        }
    }

    class CreateWorldServerDTO : IDarkRiftSerializable
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
