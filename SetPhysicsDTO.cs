using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class SetPhysicsDTO : IDarkRiftSerializable
	{
		public uint Id;
		public bool HasPhysics;
        public bool IsKinematic;

        public UMVector3 InitVelocity;

		public SetPhysicsDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.Id = e.Reader.ReadUInt32();
			this.HasPhysics = e.Reader.ReadBoolean();
            this.IsKinematic = e.Reader.ReadBoolean();

            this.InitVelocity = e.Reader.ReadSerializable<UMVector3>();

        }

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.Id);
			e.Writer.Write(this.HasPhysics);
            e.Writer.Write(this.IsKinematic);
            e.Writer.Write(this.InitVelocity);
        }
	}
}