using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class WeaponSwitchClientDTO : IDarkRiftSerializable
	{
		public ushort weaponEntityId;

		public ushort weaponSlot;

		public WeaponSwitchClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.weaponEntityId = e.Reader.ReadUInt16();
			this.weaponSlot = e.Reader.ReadUInt16();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.weaponEntityId);
			e.Writer.Write(this.weaponSlot);
		}
	}
}