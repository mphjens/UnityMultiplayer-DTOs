using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class WeaponSwitchClientDTO : IDarkRiftSerializable
    {
        public ushort weaponEntityId;
        public ushort weaponSlot;

        public void Deserialize(DeserializeEvent e)
        {
            weaponEntityId = e.Reader.ReadUInt16();
            weaponSlot = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(weaponEntityId);
            e.Writer.Write(weaponSlot);
        }
    }
}
