using DarkRift;
using System;

namespace UnityMultiplayerDRPlugin.DTOs
{
	internal class PlayerUpdateServerDTO : IDarkRiftSerializable
	{
		public ushort ID;

		public float x;

		public float y;

		public float z;

		public float rx;

		public float ry;

		public float rz;

		public float vx;

		public float vy;

		public float vz;

		public ushort[] triggerQueue;

		public PlayerUpdateServerDTO()
		{
		}

		public void Deserialize(DeserializeEvent e)
		{
			this.ID = e.Reader.ReadUInt16();
			this.x = e.Reader.ReadSingle();
			this.y = e.Reader.ReadSingle();
			this.z = e.Reader.ReadSingle();
			this.rx = e.Reader.ReadSingle();
			this.ry = e.Reader.ReadSingle();
			this.rz = e.Reader.ReadSingle();
			this.vx = e.Reader.ReadSingle();
			this.vy = e.Reader.ReadSingle();
			this.vz = e.Reader.ReadSingle();
			this.triggerQueue = e.Reader.ReadUInt16s();
		}

		public void Serialize(SerializeEvent e)
		{
			e.Writer.Write(this.ID);
			e.Writer.Write(this.x);
			e.Writer.Write(this.y);
			e.Writer.Write(this.z);
			e.Writer.Write(this.rx);
			e.Writer.Write(this.ry);
			e.Writer.Write(this.rz);
			e.Writer.Write(this.vx);
			e.Writer.Write(this.vy);
			e.Writer.Write(this.vz);
			e.Writer.Write(this.triggerQueue);
		}
	}
}