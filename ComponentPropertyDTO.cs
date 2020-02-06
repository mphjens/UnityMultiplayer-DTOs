using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DarkRift;

namespace Assets.Recover.Scripts.Assembly_CSharp.Core.Entity
{
    public class ComponentPropertyDTO : DarkRift.IDarkRiftSerializable
    {
        public string PropertyName { get; private set; }
        public object Value { get; private set; }
        public Type vType { get; private set; }

        private string typename;
        private byte[] rawValue;
        private int rawValueLength;

        public ComponentPropertyDTO() { }

        public void Deserialize(DeserializeEvent e)
        {
            PropertyName = e.Reader.ReadString();
            typename = e.Reader.ReadString();
            rawValueLength = e.Reader.ReadInt32();
            rawValue = e.Reader.ReadRaw(rawValueLength);


            //Deserialize Value obj from raw bytearray
            using (MemoryStream memStream = new MemoryStream()){
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(rawValue, 0, rawValue.Length);
                memStream.Seek(0, SeekOrigin.Begin);

                this.Value = (Object)binForm.Deserialize(memStream);
            }
               
            this.vType = Type.GetType(typename);
        }

        public void Serialize(SerializeEvent e)
        {
            if(rawValue == null)
            {
                //Convert Value to raw byte array
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, Value);

                rawValue = ms.ToArray();
                rawValueLength = rawValue.Length;
            }

            e.Writer.Write(PropertyName);
            e.Writer.Write(vType.FullName);
            e.Writer.Write(rawValueLength);
            e.Writer.Write(rawValue);
        }

        
    }
}
