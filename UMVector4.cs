using System;
using DarkRift;

namespace UnityMultiplayerDRPlugin.DTOs
{
	public class UMVector4 : DarkRift.IDarkRiftSerializable
    {
		public float x;

		public float y;

		public float z;

        public float w;

        public UMVector4(){}

        public UMVector4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
            this.w = w;
		}

        public override string ToString()
        {
            return $"(X: {x}, Y: {y}, Z: {z}, Z: {w})";
        }

        public void Deserialize(DeserializeEvent e)
        {
            x = e.Reader.ReadSingle();
            y = e.Reader.ReadSingle();
            z = e.Reader.ReadSingle();
            w = e.Reader.ReadSingle();

        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(x);
            e.Writer.Write(y);
            e.Writer.Write(z);
            e.Writer.Write(w);
        }
    }
}