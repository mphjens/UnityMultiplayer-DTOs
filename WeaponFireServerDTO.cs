using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class WeaponFireServerDTO : IDarkRiftSerializable
	{
		public ushort playerID;

		public ushort fireNum;

		public WeaponFireServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.playerID = e.Reader.ReadUInt16();
			this.fireNum = e.Reader.ReadUInt16();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.playerID);
			e.Writer.Write(this.fireNum);
		}
	}
}