using Assets.DTOs;
using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    public class SetEntityTransformDTO : IDarkRiftSerializable
    {
        public uint id;
        public UMVector3 position;
        public UMVector3 rotation;
        public UMVector3 scale;

        public void Deserialize(DeserializeEvent e)
        {
            id = e.Reader.ReadUInt32();

            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            scale = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(id);
            e.Writer.Write(position.x); e.Writer.Write(position.y); e.Writer.Write(position.z);
            e.Writer.Write(rotation.x); e.Writer.Write(rotation.y); e.Writer.Write(rotation.z);
            e.Writer.Write(scale.x); e.Writer.Write(scale.y); e.Writer.Write(scale.z);
        }
    }

}
