using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class JoinWorldServerDTO : IDarkRiftSerializable
	{
		public bool Success;

		public string Message;

		public JoinWorldServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.Success = e.Reader.ReadBoolean();
			this.Message = e.Reader.ReadString();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.Success);
			e.Writer.Write(this.Message);
		}
	}
}