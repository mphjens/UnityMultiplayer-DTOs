using Assets.DTOs;
using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;
using UnityMultiplayerDRPlugin.Entities;

namespace UnityMultiplayerDRPlugin.DTOs
{

    public class SpawnEntityClientDTO : IDarkRiftSerializable
    {
        public ushort EntityId;
        public ushort State;
        public bool hasPhysics;
        public string WorldEntityUUID = "";

        public uint parentID;
        public UMVector3 position;
        public UMVector3 rotation;
        public UMVector3 scale;


        public void Deserialize(DeserializeEvent e)
        {
            EntityId = e.Reader.ReadUInt16();
            State = e.Reader.ReadUInt16();
            hasPhysics = e.Reader.ReadBoolean();
            WorldEntityUUID = e.Reader.ReadString();
            parentID = e.Reader.ReadUInt32();

            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            scale = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(EntityId);
            e.Writer.Write(State);
            e.Writer.Write(hasPhysics);
            e.Writer.Write(WorldEntityUUID);
            e.Writer.Write(parentID);

            e.Writer.Write(position.x); e.Writer.Write(position.y); e.Writer.Write(position.z);
            e.Writer.Write(rotation.x); e.Writer.Write(rotation.y); e.Writer.Write(rotation.z);
            e.Writer.Write(scale.x); e.Writer.Write(scale.y); e.Writer.Write(scale.z);
        }
    }


    public class SpawnEntityServerDTO : IDarkRiftSerializable
    {
        public uint ID;
        public uint parentID;
        public ushort EntityId;
        public ushort State;
        public string WorldEntityUUID = ""; // if != "" It's spawned in the scene so we need to alter a exsisting object when we get a spawn message for this entity
        public bool hasPhysics;
        public bool isKinematic;
        public UMVector3 position;
        public UMVector3 rotation;
        public UMVector3 scale;
        public UMComponentDTO[] components;



        public void Deserialize(DeserializeEvent e)
        {
            ID = e.Reader.ReadUInt32();
            parentID = e.Reader.ReadUInt32();
            EntityId = e.Reader.ReadUInt16();
            State = e.Reader.ReadUInt16();
            WorldEntityUUID = e.Reader.ReadString();
            hasPhysics = e.Reader.ReadBoolean();

            position = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            rotation = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());
            scale = new UMVector3(e.Reader.ReadSingle(), e.Reader.ReadSingle(), e.Reader.ReadSingle());

            components = e.Reader.ReadSerializables<UMComponentDTO>();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(parentID);
            e.Writer.Write(EntityId);
            e.Writer.Write(State);
            e.Writer.Write(WorldEntityUUID);
            e.Writer.Write(hasPhysics);

            e.Writer.Write(position.x); e.Writer.Write(position.y); e.Writer.Write(position.z);
            e.Writer.Write(rotation.x); e.Writer.Write(rotation.y); e.Writer.Write(rotation.z);
            e.Writer.Write(scale.x); e.Writer.Write(scale.y); e.Writer.Write(scale.z);

            e.Writer.Write(components);
        }
    }
}
