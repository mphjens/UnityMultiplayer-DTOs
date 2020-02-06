using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class AddComponentClientDTO : IDarkRiftSerializable
	{
        public uint TargetID;
        public uint EntityID; //The entity id of the componentsource 

		public AddComponentClientDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.TargetID = e.Reader.ReadUInt32();
			this.EntityID = e.Reader.ReadUInt32();
        }

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.TargetID);
			e.Writer.Write(this.EntityID);
        }
	}
}