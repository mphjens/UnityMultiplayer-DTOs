using Assets.DTOs;
using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{

    public class SetParentDTO : IDarkRiftSerializable
    {
        public uint ID;
        public uint parentID;

        public UMVector3 localPosition;
        public UMVector3 localRotation;
        public UMVector3 localScale;

        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadUInt32();
            parentID = e.Reader.ReadUInt32();
            localPosition = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            localRotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            localScale = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(parentID);
        }
    }
}
