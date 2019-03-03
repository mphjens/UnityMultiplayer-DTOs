using DarkRift;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnityMultiplayerDRPlugin.DTOs
{
    class DamageHurtableServerDTO : IDarkRiftSerializable
    {
        public ushort InstagatorID;
        public ushort VictimID;
        public float damage;
        

        public void Deserialize(DeserializeEvent e)
        {
            InstagatorID = e.Reader.ReadUInt16();
            VictimID = e.Reader.ReadUInt16();
            damage = e.Reader.ReadSingle();
        }

        public void Serialize(SerializeEvent e)
        {
            e.Writer.Write(InstagatorID);
            e.Writer.Write(VictimID);
            e.Writer.Write(damage);            
        }
    }
}
