using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class CreateWorldClientDTO : IDarkRiftSerializable
	{
		public ushort SceneEntityID;

		public string SceneName;

		public string WorldName;

		public CreateWorldClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.SceneEntityID = e.Reader.ReadUInt16();
			this.SceneName = e.Reader.ReadString();
			this.WorldName = e.Reader.ReadString();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.SceneEntityID);
			e.Writer.Write(this.SceneName);
			e.Writer.Write(this.WorldName);
		}
	}
}