using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class WeaponSwitchServerDTO : IDarkRiftSerializable
    {
        public ushort playerId;
        public uint weaponEntityId;
        public ushort weaponSlot;

        public void Deserialize(DeserializeEvent e)
        {
            playerId = e.Reader.ReadUInt16();
            weaponEntityId = e.Reader.ReadUInt32();
            weaponSlot = e.Reader.ReadUInt16();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(playerId);
            e.Writer.Write(weaponEntityId);
            e.Writer.Write(weaponSlot);
        }
    }
}
