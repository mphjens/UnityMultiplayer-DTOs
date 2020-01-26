using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class JoinWorldClientDTO : IDarkRiftSerializable
	{
		public string WorldName;

		public JoinWorldClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.WorldName = e.Reader.ReadString();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.WorldName);
		}
	}
}