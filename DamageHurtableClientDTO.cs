using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class DamageHurtableClientDTO : IDarkRiftSerializable
	{
		public ushort VictimID;

		public float damage;

		public DamageHurtableClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.VictimID = e.Reader.ReadUInt16();
			this.damage = e.Reader.ReadSingle();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.VictimID);
			e.Writer.Write(this.damage);
		}
	}
}