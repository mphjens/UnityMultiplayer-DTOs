using System;
using DarkRift;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class UMVector3 : DarkRift.IDarkRiftSerializable
    {
		public float x;

		public float y;

		public float z;

        public UMVector3()
        {

        }


        public UMVector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

        public override string ToString()
        {
            return $"(X: {x}, Y: {y}, Z: {z})";
        }

        public void Deserialize(DeserializeEvent e)
        {
            x = e.Reader.ReadSingle();
            y = e.Reader.ReadSingle();
            z = e.Reader.ReadSingle();

        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(x);
            e.Writer.Write(y);
            e.Writer.Write(z);
        }
    }
}