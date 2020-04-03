using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class CreateWorldServerDTO : IDarkRiftSerializable
	{
		public bool Success;
		public string Message;
		public WorldDTO WorldData;

		public CreateWorldServerDTO()
		{

		}

		public void Deserialize(DeserializeEvent e)
		{
			this.Success = e.Reader.ReadBoolean();
			this.Message = e.Reader.ReadString();
			if(this.Success)
				this.WorldData = e.Reader.ReadSerializable<WorldDTO>();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.Success);
			e.Writer.Write(this.Message);
			if(this.Success)
				e.Writer.Write(this.WorldData);
		}
	}
}