using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class WeaponFireServerDTO : IDarkRiftSerializable
    {
        public ushort playerID;
        public ushort fireNum;

        public void Deserialize(DeserializeEvent e)
        {
            playerID = e.Reader.ReadUInt16();
            fireNum = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(entityID);
        }
    }
}
