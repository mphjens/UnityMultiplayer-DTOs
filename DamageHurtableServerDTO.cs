using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class DamageHurtableServerDTO : IDarkRiftSerializable
	{
		public ushort InstagatorID;

		public ushort VictimID;

		public float damage;

		public DamageHurtableServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.InstagatorID = e.Reader.ReadUInt16();
			this.VictimID = e.Reader.ReadUInt16();
			this.damage = e.Reader.ReadSingle();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.InstagatorID);
			e.Writer.Write(this.VictimID);
			e.Writer.Write(this.damage);
		}
	}
}