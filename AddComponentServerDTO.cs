using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class AddComponentServerDTO : IDarkRiftSerializable
	{
        public uint ID;
		public uint EntityID; //The entity id of the componentsource 
		public uint TargetID;

		public AddComponentServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.ID = e.Reader.ReadUInt32();
			this.EntityID = e.Reader.ReadUInt32();
            this.TargetID = e.Reader.ReadUInt32();
        }

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.ID);
			e.Writer.Write(this.EntityID);
            e.Writer.Write(this.TargetID);
        }
	}
}