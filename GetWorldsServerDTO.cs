using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class GetWorldsServerDTO : IDarkRiftSerializable
	{
		public WorldDTO[] Worlds;

		public GetWorldsServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.Worlds = e.Reader.ReadSerializables<WorldDTO>();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write<WorldDTO>(this.Worlds);
		}
	}
}