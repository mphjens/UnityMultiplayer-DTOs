using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class WeaponFireClientDTO : IDarkRiftSerializable
	{
		public ushort fireNum;

		public WeaponFireClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.fireNum = e.Reader.ReadUInt16();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.fireNum);
		}
	}
}