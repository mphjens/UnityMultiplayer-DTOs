using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class WeaponFireClientDTO : IDarkRiftSerializable
    {
        public ushort fireNum;

        public void Deserialize(DeserializeEvent e)
        {
            fireNum = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(fireNum);
        }
    }
}
