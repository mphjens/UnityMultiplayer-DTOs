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
        public uint ComponentID;
        public string PropertyName { get; set; }
        //public object Value { get; private set; }
        //public Type vType { get; private set; }

        public string TypeName; //Is set be setValueObject
        public byte[] RawValue; //Is set by setValueObject
        public int RawValueLength; //Is set by setValueObject

        public ComponentPropertyDTO() { }

        public object ConstructValue()
        {
            //Deserialize Value obj from raw bytearray
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(RawValue, 0, RawValue.Length);
                memStream.Seek(0, SeekOrigin.Begin);

                return (Object)binForm.Deserialize(memStream);
            }
        }

        public void setValueObject(object valueObj)
        {
            if (RawValue == null)
            {
                //Convert Value to raw byte array
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, valueObj);

                RawValue = ms.ToArray();
                RawValueLength = RawValue.Length;

                TypeName = valueObj.GetType().FullName;
            }
        }

        public void Deserialize(DeserializeEvent e)
        {
            ComponentID = e.Reader.ReadUInt32();
            PropertyName = e.Reader.ReadString();
            TypeName = e.Reader.ReadString();
            RawValueLength = e.Reader.ReadInt32();
            RawValue = e.Reader.ReadRaw(RawValueLength);
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ComponentID);
            e.Writer.Write(PropertyName);
            e.Writer.Write(TypeName);
            e.Writer.Write(RawValueLength);
            e.Writer.WriteRaw(RawValue, 0, RawValueLength);
        }

        
    }
}
