using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class PlayerSpawnServerDTO : IDarkRiftSerializable
	{
		public ushort ID;

		public ushort entityID;

		public float x;

		public float y;

		public float z;

		public float health;

		public PlayerSpawnServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.ID = e.Reader.ReadUInt16();
			this.entityID = e.Reader.ReadUInt16();
			this.x = e.Reader.ReadSingle();
			this.y = e.Reader.ReadSingle();
			this.z = e.Reader.ReadSingle();
			this.health = e.Reader.ReadSingle();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.ID);
			e.Writer.Write(this.entityID);
			e.Writer.Write(this.x);
			e.Writer.Write(this.y);
			e.Writer.Write(this.z);
			e.Writer.Write(this.health);
		}
	}
}