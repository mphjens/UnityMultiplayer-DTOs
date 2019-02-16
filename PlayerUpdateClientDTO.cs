using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class PlayerUpdateClientDTO : IDarkRiftSerializable
    {
        public float x, y, z;
        public float rx, ry, rz;

        public void Deserialize(DeserializeEvent e)
        {
            x = e.Reader.ReadSingle();
            y = e.Reader.ReadSingle();
            z = e.Reader.ReadSingle();

            rx = e.Reader.ReadSingle();
            ry = e.Reader.ReadSingle();
            rz = e.Reader.ReadSingle();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(x);
            e.Writer.Write(y);
            e.Writer.Write(z);

            e.Writer.Write(rx);
            e.Writer.Write(ry);
            e.Writer.Write(rz);
        }
    }
}
