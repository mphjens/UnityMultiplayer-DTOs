using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class PlayerSpawnClientDTO : IDarkRiftSerializable
	{
		public ushort entityID;

		public PlayerSpawnClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.entityID = e.Reader.ReadUInt16();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.entityID);
		}
	}
}