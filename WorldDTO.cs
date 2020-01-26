using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class WorldDTO : IDarkRiftSerializable
	{
		public string WorldName;

		public int NrPlayers;

		public int MaxNrPlayers;

		public ushort SceneEntityID;

		public string SceneName;

		public WorldDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.WorldName = e.Reader.ReadString();
			this.NrPlayers = e.Reader.ReadInt32();
			this.MaxNrPlayers = e.Reader.ReadInt32();
			this.SceneEntityID = e.Reader.ReadUInt16();
			this.SceneName = e.Reader.ReadString();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.WorldName);
			e.Writer.Write(this.NrPlayers);
			e.Writer.Write(this.MaxNrPlayers);
			e.Writer.Write(this.SceneEntityID);
			e.Writer.Write(this.SceneName);
		}
	}
}