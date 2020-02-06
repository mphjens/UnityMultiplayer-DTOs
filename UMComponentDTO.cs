using Assets.Recover.Scripts.Assembly_CSharp.Core.Entity;
using DarkRift;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.Entities
{
    public class UMComponentDTO : DarkRift.IDarkRiftSerializable
    {
        public uint ID;
        public uint TargetID;
        public uint EntityID;
        public List<ComponentPropertyDTO> Properties;

        public UMComponentDTO()
        {
            Properties = new List<ComponentPropertyDTO>();
        }

        public void Deserialize(DeserializeEvent e)
        {
            this.ID = e.Reader.ReadUInt32();
            this.TargetID = e.Reader.ReadUInt32();
            this.EntityID = e.Reader.ReadUInt32();
            this.Properties.AddRange(e.Reader.ReadSerializables<ComponentPropertyDTO>());
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(ID);
            e.Writer.Write(TargetID);
            e.Writer.Write(EntityID);
            e.Writer.Write<ComponentPropertyDTO>(Properties.ToArray());
        }

        public void AddOrUpdateProperty(ComponentPropertyDTO property)
        {
            ComponentPropertyDTO existingProperty = this.Properties
                                                    .Where((x) => { return x.PropertyName == property.PropertyName; })
                                                    .FirstOrDefault();

            if(existingProperty == null)
            {
                ComponentPropertyDTO nProperty = property;
                this.Properties.Add(nProperty);
            }
            else
            {
                existingProperty.RawValue = property.RawValue;
                existingProperty.RawValueLength = property.RawValueLength;
            }
            
        }
    }
}
