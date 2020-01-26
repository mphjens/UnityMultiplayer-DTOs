using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class WeaponSwitchServerDTO : IDarkRiftSerializable
	{
		public ushort playerId;

		public ushort weaponEntityId;

		public ushort weaponSlot;

		public WeaponSwitchServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.playerId = e.Reader.ReadUInt16();
			this.weaponEntityId = e.Reader.ReadUInt16();
			this.weaponSlot = e.Reader.ReadUInt16();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.playerId);
			e.Writer.Write(this.weaponEntityId);
			e.Writer.Write(this.weaponSlot);
		}
	}
}