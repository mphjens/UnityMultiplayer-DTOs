using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class PlayerUpdateClientDTO : IDarkRiftSerializable
    {
        public float x, y, z;
        public float rx, ry, rz;
        public float vx, vy, vz;
        public ushort[] triggerQueue;

        public void Deserialize(DeserializeEvent e)
        {
            x = e.Reader.ReadSingle();
            y = e.Reader.ReadSingle();
            z = e.Reader.ReadSingle();

            rx = e.Reader.ReadSingle();
            ry = e.Reader.ReadSingle();
            rz = e.Reader.ReadSingle();

            vx = e.Reader.ReadSingle();
            vy = e.Reader.ReadSingle();
            vz = e.Reader.ReadSingle();

            triggerQueue = e.Reader.ReadUInt16s();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(x);
            e.Writer.Write(y);
            e.Writer.Write(z);

            e.Writer.Write(rx);
            e.Writer.Write(ry);
            e.Writer.Write(rz);

            e.Writer.Write(vx);
            e.Writer.Write(vy);
            e.Writer.Write(vz);

            e.Writer.Write(this.triggerQueue);
        }
    }
}
