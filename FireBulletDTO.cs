using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class FireBulletDTO : IDarkRiftSerializable
    {
        public ushort BulletEntityID;
        public ushort WeaponEntityID;
        public ushort ownerPlayerID;

        public UMVector3 Origin;
        public UMVector3 Velocity;
        public bool UseGravity;

        public ushort bulletId = 0;

        public void Deserialize(DeserializeEvent e)
        {
            bulletId = e.Reader.ReadUInt16();
            BulletEntityID = e.Reader.ReadUInt16();
            WeaponEntityID = e.Reader.ReadUInt16();
            ownerPlayerID = e.Reader.ReadUInt16();
            

            Origin = new UMVector3(e.Reader.ReadUInt16(), e.Reader.ReadUInt16(), e.Reader.ReadUInt16());
            Velocity = new UMVector3(e.Reader.ReadUInt16(), e.Reader.ReadUInt16(), e.Reader.ReadUInt16());
            UseGravity = e.Reader.ReadBoolean();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(bulletId);
            e.Writer.Write(BulletEntityID);
            e.Writer.Write(WeaponEntityID);
            e.Writer.Write(ownerPlayerID);
            e.Writer.Write(Origin.x); e.Writer.Write(Origin.y); e.Writer.Write(Origin.z);
            e.Writer.Write(Velocity.x); e.Writer.Write(Velocity.y); e.Writer.Write(Velocity.z);
            e.Writer.Write(UseGravity);
        }
    }

    class BulletHitDTO : IDarkRiftSerializable
    {

        public ushort bulletId = 0;
        public UMVector3 Origin;
        public UMVector3 Rotation;

        public void Deserialize(DeserializeEvent e)
        {
            bulletId = e.Reader.ReadUInt16();

            Origin = new UMVector3(e.Reader.ReadUInt16(), e.Reader.ReadUInt16(), e.Reader.ReadUInt16());
            Rotation = new UMVector3(e.Reader.ReadUInt16(), e.Reader.ReadUInt16(), e.Reader.ReadUInt16());
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(bulletId);
            e.Writer.Write(Origin.x); e.Writer.Write(Origin.y); e.Writer.Write(Origin.z);
            e.Writer.Write(Rotation.x); e.Writer.Write(Rotation.y); e.Writer.Write(Rotation.z);
        }
    }
}
